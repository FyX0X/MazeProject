using System;

namespace MazeProject
{
    static class MazeGenerator
    {

        //hunt and kill
        private static Maze maze;
        public static int x, y = 0;
        public static Cell[,] gridConstruct;
        private static int wallsToDelete;
        public static int gridWidth, gridHeight;

        static Random rng = new Random();

        public static Maze Create(int _gridWidth, int _gridHeight, bool multipleSolution, int[] startPos, int[] endPos)
        {
            x = 0;
            y = 0;

            gridWidth = _gridWidth;
            gridHeight = _gridHeight;

            //create a 2D array filled with Cells
            gridConstruct = new Cell[gridWidth, gridHeight];

            //initialize starting cell
            gridConstruct[x, y] = new Cell();

            bool isCompleted = false;

            Console.WriteLine($"Starting generation of a {gridWidth}x{gridHeight} maze");

            while (!isCompleted)
            {
                //Console.WriteLine("----------------------------------------------- starting one construction iteration. continue...");

                //Console.WriteLine($"Current cell : ({x};{y})");

                bool[] canMoveTo = CheckCell.CheckMove(x, y, gridConstruct);



                if (canMoveTo[4]) walk();
                else isCompleted = hunt();

            }

            //delete some wall to have multiple path
            if (multipleSolution)
            {
                //find how many wall to delete
                wallsToDelete = Convert.ToInt32(Math.Sqrt(gridWidth * gridHeight)/1);

                for (int i = 0; i < wallsToDelete; i++)
                {
                    int xToDelete = rng.Next(gridWidth);
                    int yToDelete = rng.Next(gridHeight);

                    int wallDirection = rng.Next(0, 4);
                    

                    while (wallDirection == 0 && yToDelete == 0 || 
                        wallDirection == 1 && yToDelete == gridHeight - 1 || 
                        wallDirection == 2 && xToDelete == 0 ||
                        wallDirection == 3 && xToDelete == gridWidth - 1) wallDirection = rng.Next(0, 4);

                    deleteWall(xToDelete, yToDelete, wallDirection);
                }
                
            }

            maze = new Maze(gridConstruct);


            maze.start = startPos;
            maze.end = endPos;
            
            
            return maze;

        }


        static void deleteWall(int xFrom, int yFrom, int direction)
        {
            
            switch (direction)
            {
                case 0:
                    //deleting walls
                    gridConstruct[xFrom, yFrom].wallUp = false;
                    gridConstruct[xFrom, yFrom - 1].wallDown = false;
                    break;
                case 1:
                    //deleting walls
                    gridConstruct[xFrom, yFrom].wallDown = false;
                    gridConstruct[xFrom, yFrom + 1].wallUp = false;
                    break;
                case 2:
                    //deleting walls
                    gridConstruct[xFrom, yFrom].wallLeft = false;
                    gridConstruct[xFrom - 1, yFrom].wallRight = false;
                    break;
                case 3:
                    //deleting walls
                    gridConstruct[xFrom, yFrom].wallRight = false;
                    gridConstruct[xFrom + 1, yFrom].wallLeft = false;
                    break;
            }
        }
        static void walk()
        {
            //Console.WriteLine("Walk:");

            bool[] canMoveTo = CheckCell.CheckMove(x, y, gridConstruct);

            int move = rng.Next(0, 4); // 0: up, 1: down, 2: left, 3: right
            while (!canMoveTo[move]) move = rng.Next(0, 4);

            switch (move)
            {
                case 0:

                    gridConstruct[x, y - 1] = new Cell();

                    //deleting walls
                    deleteWall(x, y, 0);

                    //updating position
                    y--;

                    break;
                case 1:
                    gridConstruct[x, y + 1] = new Cell();

                    //deleting walls
                    deleteWall(x, y, 1);

                    //updating position
                    y++;

                    break;
                case 2:
                    gridConstruct[x - 1, y] = new Cell();

                    //deleting walls
                    deleteWall(x, y, 2);

                    //updating position
                    x--;

                    break;
                case 3:
                    gridConstruct[x + 1, y] = new Cell();

                    //deleting walls
                    deleteWall(x, y, 3);

                    //updating position
                    x++;

                    break;
            }

            //Console.WriteLine($"Move to cell ({x};{y}) => Walk finish.");
        }

        static bool hunt()
        {
            //Console.WriteLine(">> Hunt:");

            bool isMazeCompleted = true;

            for (int huntY = 0; huntY < gridHeight; huntY++)
            {
                for (int huntX = 0; huntX < gridWidth; huntX++)
                {

                    if (gridConstruct[huntX, huntY] == null)
                    {
                        //Console.WriteLine($"found a free cell. check for connection with main way...");

                        isMazeCompleted = false;

                        bool[] isConnected = CheckCell.CheckConnection(huntX, huntY, gridConstruct);

                        if (isConnected[4])
                        {
                            x = huntX;
                            y = huntY;
                            //Console.WriteLine($"Teleport to cell ({x};{y}) => Hunt finish.");
                            gridConstruct[x, y] = new Cell();

                            //connect cells
                            int cellToConnect = rng.Next(0, 4); // 0: up, 1: down, 2: left, 3: right
                            while (!isConnected[cellToConnect]) cellToConnect = rng.Next(0, 4);

                            switch (cellToConnect)
                            {
                                case 0:
                                    //deleting wall
                                    deleteWall(x, y, 0);
                                    break;
                                case 1:
                                    //deleting wall
                                    deleteWall(x, y, 1);
                                    break;
                                case 2:
                                    //deleting wall
                                    deleteWall(x, y, 2);
                                    break;
                                case 3:
                                    //deleting wall
                                    deleteWall(x, y, 3);
                                    break;
                            }

                            return false;
                        }
                        //else Console.WriteLine("Failed. cell not connected.");

                    }
                }
            }

            if (isMazeCompleted)
            {
                Console.WriteLine("Maze completed."); // Check if all cells are visited => creation finish
                return true;
            }
            else
            {
                Console.WriteLine("---- return false ------");
                return false;
            }
        }
    }
}