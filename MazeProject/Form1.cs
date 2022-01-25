using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MazeProject
{
    public partial class Form1 : Form
    {
        public static int gridWidth, gridHeight;
        public static bool areStartEndPosCorner;
        public static int[] startPos, endPos;
        public static bool rngStartEnd;
        public static bool changeSEMode;
        public Maze maze;
        public bool showSolution;
        public bool showStartEnd;
        int cellSize = 10;
        int xSpacing = 125;
        int ySpacing = 30;

        public string dataPath;

        private static Random rng = new Random(); 

        public Form1()
        {
            InitializeComponent();
            Initialize();


            gridWidth = Convert.ToInt32(mazeWidth.Value);
            gridHeight = Convert.ToInt32(mazeHeight.Value);


            areStartEndPosCorner = true;
            startPos = new int[] { 0, 0};
            endPos = new int[] {gridWidth - 1, gridHeight - 1};


            showSolution = showSolutionCB.Checked;
            showStartEnd = showStartEndCB.Checked;

            rngStartEnd = rngStartEndCB.Checked;

            changeSEMode = changeSEModeCB.Checked;

        }

        private void Initialize()
        {
            string currDir = Directory.GetCurrentDirectory();
            Directory.CreateDirectory(currDir + @"\mazeData");

        }

        private void mazeWidth_ValueChanged(object sender, EventArgs e)
        {
            gridWidth = Convert.ToInt32(mazeWidth.Value);
            if (startPos[0] >= gridWidth || endPos[0] >= gridWidth) areStartEndPosCorner = true;
            if(areStartEndPosCorner)
            {
                startPos = new int[] { 0, 0 };
                endPos = new int[] { gridWidth - 1, gridHeight - 1 };
            }
        }

        private void mazeHeight_ValueChanged(object sender, EventArgs e)
        {
            gridHeight = Convert.ToInt32(mazeHeight.Value);
            if(startPos[1] >= gridHeight || endPos[1] >= gridHeight) areStartEndPosCorner = true;
            if (areStartEndPosCorner)
            {
                startPos = new int[] { 0, 0 };
                endPos = new int[] { gridWidth - 1, gridHeight - 1 };
            }
        }


        private void saveMazeB_Click(object sender, EventArgs e)
        {
            if(dataPath == null)
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    dataPath = folderBrowserDialog.SelectedPath;
                }
                else return;
            }

            if (maze.solution == null)
            {
                Console.WriteLine("Solving...");

                long startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                maze = MazeSolver.bfs(maze);
                long endTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                Console.WriteLine($">>solving ended in {endTime - startTime}ms");

                showSolutionCB.Enabled = true;
            }

            SaveSystem.SaveMaze(maze, dataPath);
        }

        private void loadMazeB_Click(object sender, EventArgs e)
        {
            string loadPath;

            
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadPath = openFileDialog.FileName;
                maze = SaveSystem.LoadMaze(loadPath);

            }

            gridWidth = maze.grid.GetLength(0);
            gridHeight = maze.grid.GetLength(1);
            mazeWidth.Value = gridWidth;
            mazeHeight.Value = gridHeight;

            startPos = maze.start;
            endPos = maze.end;
            
            saveMazeB.Enabled = true;
            paintMaze();
        }

        private void paintMaze()
        {
            //initialize graphics pen brush, etc...
            Graphics g = CreateGraphics();
            Pen pen = new Pen(Color.Black);
            Pen solutionPen = new Pen(Color.Blue);
            Brush brush = new SolidBrush(Color.White);
            Brush startBrush = new SolidBrush(Color.Green);
            Brush endBrush = new SolidBrush(Color.Red);


            gridWidth = maze.grid.GetLength(0);
            gridHeight = maze.grid.GetLength(1);


            //Draw Maze
            Console.WriteLine("erase last maze");
            clearMaze();

            g.FillRectangle(brush, new Rectangle(new Point(xSpacing, ySpacing), new Size(cellSize * gridWidth + 1, cellSize * gridHeight + 1)));


            for (int cellX = 0; cellX < gridWidth; cellX++)
            {
                for (int cellY = 0; cellY < gridHeight; cellY++)
                {
                    // draw start/end
                    if (showStartEnd)
                    {
                        //draw start cell
                        if (cellX == maze.start[0] && cellY == maze.start[1])
                        {
                            g.FillRectangle(startBrush, new Rectangle(
                                new Point(xSpacing + cellX * cellSize, ySpacing + cellY * cellSize),
                                new Size(cellSize, cellSize)));
                        }

                        if (cellX == maze.end[0] && cellY == maze.end[1])
                        {
                            //draw end cell
                            g.FillRectangle(endBrush, new Rectangle(
                                new Point(xSpacing + cellX * cellSize, ySpacing + cellY * cellSize),
                                new Size(cellSize, cellSize)));
                        }



                    }



                    if (maze.grid[cellX, cellY].wallUp)
                    {
                        Point startPoint = new Point(xSpacing + cellX * cellSize, ySpacing + cellY * cellSize);
                        Point endPoint = new Point(xSpacing + cellX * cellSize + cellSize, ySpacing + cellY * cellSize);
                        g.DrawLine(pen, startPoint, endPoint);
                    }
                    if (maze.grid[cellX, cellY].wallDown)
                    {
                        Point startPoint = new Point(xSpacing + cellX * cellSize, ySpacing + cellY * cellSize + cellSize);
                        Point endPoint = new Point(xSpacing + cellX * cellSize + cellSize, ySpacing + cellY * cellSize + cellSize);
                        g.DrawLine(pen, startPoint, endPoint);
                    }
                    if (maze.grid[cellX, cellY].wallLeft)
                    {
                        Point startPoint = new Point(xSpacing + cellX * cellSize, ySpacing + cellY * cellSize);
                        Point endPoint = new Point(xSpacing + cellX * cellSize, ySpacing + cellY * cellSize + cellSize);
                        g.DrawLine(pen, startPoint, endPoint);
                    }
                    if (maze.grid[cellX, cellY].wallRight)
                    {
                        Point startPoint = new Point(xSpacing + cellX * cellSize + cellSize, ySpacing + cellY * cellSize);
                        Point endPoint = new Point(xSpacing + cellX * cellSize + cellSize, ySpacing + cellY * cellSize + cellSize);
                        g.DrawLine(pen, startPoint, endPoint);
                    }

                }
            }

            if (showSolution)
            {
                int x = xSpacing + maze.start[0] * cellSize + cellSize / 2;
                int y = ySpacing + maze.start[1] * cellSize + cellSize / 2;

                foreach (char move in maze.solution)
                {
                    switch (move)
                    {
                        case 'U':
                            g.DrawLine(solutionPen, x, y, x, y - cellSize);
                            y -= cellSize;
                            break;
                        case 'D':
                            g.DrawLine(solutionPen, x, y, x, y + cellSize);
                            y += cellSize;
                            break;
                        case 'L':
                            g.DrawLine(solutionPen, x, y, x - cellSize, y);
                            x -= cellSize;
                            break;
                        case 'R':
                            g.DrawLine(solutionPen, x, y, x + cellSize, y);
                            x += cellSize;
                            break;

                    }
                }
            }

            g.Dispose();

        }

        private void changeFileDirB_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                dataPath = folderBrowserDialog.SelectedPath;
            }
        }

        private void showSolutionCB_CheckedChanged(object sender, EventArgs e)
        {
            showSolution = showSolutionCB.Checked;
            if (maze != null) paintMaze();
        }

        private void rngStartEndCB_CheckedChanged(object sender, EventArgs e)
        {
            rngStartEnd = rngStartEndCB.Checked;
            if (rngStartEnd) areStartEndPosCorner = false;
        }

        private void paintchangeSEGrid()
        {
            Graphics g = CreateGraphics();
            Pen pen = new Pen(Color.Black);
            Brush font = new SolidBrush(Color.White);
            Brush startBrush = new SolidBrush(Color.Green);
            Brush endBrush = new SolidBrush(Color.Red);

            //enter change start/end mode

            clearMaze();

            Rectangle borderRect = new Rectangle(new Point(xSpacing, ySpacing), new Size(gridWidth * cellSize, gridHeight * cellSize));

            g.FillRectangle(font, borderRect);
            g.DrawRectangle(pen, borderRect);

            //draw start end cell
            g.FillRectangle(startBrush, new Rectangle(
                new Point(
                    xSpacing + maze.start[0] * cellSize,
                    ySpacing + maze.start[1] * cellSize),
                new Size(cellSize, cellSize)));
            g.FillRectangle(endBrush, new Rectangle(
                new Point(
                    xSpacing + maze.end[0] * cellSize,
                    ySpacing + maze.end[1] * cellSize),
                new Size(cellSize, cellSize)));

            for (int c = 0; c < gridWidth; c++)
            {
                g.DrawLine(pen, new Point(xSpacing + c * cellSize, ySpacing), new Point(xSpacing + c * cellSize, ySpacing + gridHeight * cellSize));
            }
            for (int r = 0; r < gridHeight; r++)
            {
                g.DrawLine(pen, new Point(xSpacing, ySpacing + r * cellSize), new Point(xSpacing + gridWidth * cellSize, ySpacing + r * cellSize));
            }

            g.Dispose();
        }

        private void clearMaze()
        {
            Graphics g = CreateGraphics();
            g.Clear(SystemColors.Control);
            g.Dispose();
        }

        private void changeSEModeCB_CheckedChanged(object sender, EventArgs e)
        {
            changeSEMode = changeSEModeCB.Checked;


            if (changeSEMode)
            {

                //disable button and stuff
                generateMaze.Enabled = false;
                mazeWidth.Enabled = false;
                mazeHeight.Enabled = false;
                multiSolutionCB.Enabled = false;
                showStartEndCB.Enabled = false;
                showSolutionCB.Enabled = false;
                rngStartEndCB.Enabled = false;
                saveMazeB.Enabled = false;
                loadMazeB.Enabled = false;
                changeFileDirB.Enabled = false;

                //enable movemement button
                resetSEPosB.Visible = true;
                startPosL.Visible = true;
                endPosL.Visible = true;
                startMoveUpB.Visible = true;
                startMoveDownB.Visible = true;
                startMoveLeftB.Visible = true;
                startMoveRightB.Visible = true;
                endMoveUpB.Visible = true;
                endMoveDownB.Visible = true;
                endMoveLeftB.Visible = true;
                endMoveRightB.Visible = true;

                //paint grid change start/end mode

                paintchangeSEGrid();

            }
            else
            {

                //leave change start/End mode
                clearMaze();

                MazeSolver.bfs(maze);

                paintMaze();

                //enable button and stuff
                generateMaze.Enabled = true;
                mazeWidth.Enabled = true;
                mazeHeight.Enabled = true;
                multiSolutionCB.Enabled = true;
                showStartEndCB.Enabled = true;
                showSolutionCB.Enabled = true;
                rngStartEndCB.Enabled = true;
                saveMazeB.Enabled = true;
                loadMazeB.Enabled = true;
                changeFileDirB.Enabled = true;


                //disable movemement button
                resetSEPosB.Visible = false;
                startPosL.Visible = false;
                endPosL.Visible = false;
                startMoveUpB.Visible = false;
                startMoveDownB.Visible = false;
                startMoveLeftB.Visible = false;
                startMoveRightB.Visible = false;
                endMoveUpB.Visible = false;
                endMoveDownB.Visible = false;
                endMoveLeftB.Visible = false;
                endMoveRightB.Visible = false;
            }


        }



        private void resetSEPosB_Click(object sender, EventArgs e)
        {

            rngStartEndCB.Checked = false;
            rngStartEnd = false;
            areStartEndPosCorner = true;

            startPos = new int[] { 0, 0 };
            maze.start = startPos;
            endPos = new int[] { gridWidth - 1, gridHeight - 1 };
            maze.end = endPos;

            paintchangeSEGrid();
        }

        private void startMoveUpB_Click(object sender, EventArgs e)
        {
            rngStartEndCB.Checked = false;
            rngStartEnd = false;
            areStartEndPosCorner = false;

            if (startPos[1] == 0) return;
            startPos[1]--;
            maze.start = startPos;
            paintchangeSEGrid();
        }

        private void startMoveDownB_Click(object sender, EventArgs e)
        {
            rngStartEndCB.Checked = false;
            rngStartEnd = false;
            areStartEndPosCorner = false;

            if(startPos[1] == gridHeight - 1) return;
            startPos[1]++;
            maze.start = startPos;
            paintchangeSEGrid();
        }

        private void startMoveLeftB_Click(object sender, EventArgs e)
        {
            rngStartEndCB.Checked = false;
            rngStartEnd = false;
            areStartEndPosCorner = false;

            if(startPos[0] == 0) return;
            startPos[0]--;
            maze.start = startPos;
            paintchangeSEGrid();
        }

        private void startMoveRightB_Click(object sender, EventArgs e)
        {
            rngStartEndCB.Checked = false;
            rngStartEnd = false;
            areStartEndPosCorner = false;

            if(startPos[0] == gridWidth - 1) return;
            startPos[0]++;
            maze.start = startPos;
            paintchangeSEGrid();
        }

        private void endMoveUpB_Click(object sender, EventArgs e)
        {
            rngStartEndCB.Checked = false;
            rngStartEnd = false;
            areStartEndPosCorner = false;

            if (endPos[1] == 0) return;
            endPos[1]--;
            maze.end = endPos;
            paintchangeSEGrid();
        }

        private void endMoveDownB_Click(object sender, EventArgs e)
        {
            rngStartEndCB.Checked = false;
            rngStartEnd = false;
            areStartEndPosCorner = false;

            if (endPos[1] == gridHeight - 1) return;
            endPos[1]++;
            maze.end = endPos;
            paintchangeSEGrid();
        }

        private void endMoveLeftB_Click(object sender, EventArgs e)
        {
            rngStartEndCB.Checked = false;
            rngStartEnd = false;
            areStartEndPosCorner = false;

            if (endPos[0] == 0) return;
            endPos[0]--;
            maze.end = endPos;
            paintchangeSEGrid();
        }

        private void endMoveRightB_Click(object sender, EventArgs e)
        {
            rngStartEndCB.Checked = false;
            rngStartEnd = false;
            areStartEndPosCorner = false;

            if (endPos[0] == gridWidth - 1) return;
            endPos[0]++;
            maze.end = endPos;
            paintchangeSEGrid();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine($"click ({e.X};{e.Y})");

            if (changeSEMode)
            {
                double cX = (e.X - xSpacing) / cellSize;
                double cY = (e.Y - ySpacing) / cellSize;
                int cellX = Convert.ToInt32(Math.Round(cX));
                int cellY = Convert.ToInt32(Math.Round(cY));

                if( 0 <= cellX && cellX < gridWidth && 0 <= cellY && cellY < gridHeight)
                {
                    if(e.Button == MouseButtons.Left)
                    {
                        startPos = new int[] { cellX, cellY };
                        maze.start = startPos;
                        paintchangeSEGrid();
                    }
                    if(e.Button == MouseButtons.Right)
                    {
                        endPos = new int[] { cellX, cellY };
                        maze.end = endPos;paintchangeSEGrid();
                    }
                }

            }
        }

        private void showStartEndCB_CheckedChanged(object sender, EventArgs e)
        {
            showStartEnd = showStartEndCB.Checked;
            if(maze != null) paintMaze();
        }

        private void generateMaze_Click(object sender, EventArgs e)
        {

            //generate Maze
            Console.WriteLine("Generating maze...");

            long startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();


            if (rngStartEnd)
            {
                startPos[0] = rng.Next(gridWidth);
                startPos[1] = rng.Next(gridHeight);

                endPos[0] = rng.Next(gridWidth - 1);
                endPos[1] = rng.Next(gridHeight - 1);

                maze = MazeGenerator.Create(gridWidth, gridHeight, multiSolutionCB.Checked, areStartEndPosCorner);
            } else
            {
                maze = MazeGenerator.Create(gridWidth, gridHeight, multiSolutionCB.Checked, areStartEndPosCorner);
            }


            long endTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Console.WriteLine($">>generation ended in {endTime - startTime}ms");

            Console.WriteLine("Maze generated.");
            
            
            //solve Maze
            Console.WriteLine("Solving...");

            startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            maze = MazeSolver.bfs(maze);
            endTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Console.WriteLine($">>solving ended in {endTime - startTime}ms");


            saveMazeB.Enabled = true;

            paintMaze();

        }

    }
}
