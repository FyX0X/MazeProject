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
        public Maze maze;
        public bool showSolution;

        public string dataPath;

        public Form1()
        {
            InitializeComponent();
            Initialize();


            gridWidth = 16;
            gridHeight = 16;
        }

        private void Initialize()
        {
            string currDir = Directory.GetCurrentDirectory();
            Directory.CreateDirectory(currDir + @"\mazeData");

        }

        private void mazeWidth_ValueChanged(object sender, EventArgs e)
        {
            gridWidth = Convert.ToInt32(mazeWidth.Value);
        }

        private void mazeHeight_ValueChanged(object sender, EventArgs e)
        {
            gridHeight = Convert.ToInt32(mazeHeight.Value);
        }


        private void saveMazeB_Click(object sender, EventArgs e)
        {
            if(dataPath == null)
            {
                if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    dataPath = folderBrowserDialog.SelectedPath;
                }
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
            
            saveMazeB.Enabled = true;
            paintMaze();
        }

        private void paintMaze()
        {
            //initialize graphics pen brush, etc...
            Graphics g = CreateGraphics();
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.White);
            Brush baseFontBrush = new SolidBrush(SystemColors.Control);
            Brush startBrush = new SolidBrush(Color.Green);
            Brush endBrush = new SolidBrush(Color.Red);
            int cellSize = 10;
            int xSpacing = 125;
            int ySpacing = 25;

            gridWidth = maze.grid.GetLength(0);
            gridHeight = maze.grid.GetLength(1);


            //Draw Maze
            Console.WriteLine("erase last maze");
            g.FillRectangle(baseFontBrush, new Rectangle(new Point(xSpacing, ySpacing), new Size(cellSize * 50, cellSize * 50)));

            g.FillRectangle(brush, new Rectangle(new Point(xSpacing, ySpacing), new Size(cellSize * gridWidth + 1, cellSize * gridHeight + 1)));

            //draw start cell
            if (showStartEndCB.Checked)
            {
                g.FillRectangle(startBrush, new Rectangle(
                    new Point(xSpacing + maze.start[0] * cellSize, ySpacing + maze.start[1] * cellSize),
                    new Size(cellSize, cellSize)));
            }
            for (int cellX = 0; cellX < gridWidth; cellX++)
            {
                for (int cellY = 0; cellY < gridHeight; cellY++)
                {


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
            //draw end cell
            if (showStartEndCB.Checked)
            {
                g.FillRectangle(endBrush, new Rectangle(
                    new Point(xSpacing + maze.end[0] * cellSize, ySpacing + maze.end[1] * cellSize),
                    new Size(cellSize, cellSize)));

            }

        }

        private void changeFileDirB_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                dataPath = folderBrowserDialog.SelectedPath;
            }
        }

        private void generateMaze_Click(object sender, EventArgs e)
        {
            //generate Maze
            Console.WriteLine("Generating maze...");

            long startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            maze = new Maze(MazeGenerator.Create(gridWidth, gridHeight, multiSolutionCB.Checked));

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
