using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProject
{
    static class MazeSolver
    {
        public static Maze bfs(Maze maze)
        {
            int[] start = maze.start;
            int[] end = maze.end;


            Queue paths = new Queue();

            //bool[,] visited = new bool[maze.grid.GetLength(0), maze.grid.GetLength(1)];

            string add = "";
            paths.Enqueue(add);

            while (!findEnd(maze, add))
            {

                add = paths.Dequeue() as string;

                foreach (char c in "UDLR")
                {
                    string put = add + c;

                    if (validMove(maze, put)) paths.Enqueue(put);

                }
            }

            return maze;

        }

        static bool validMove(Maze maze, string moves)
        {
            int x = maze.start[0];
            int y = maze.start[1];


            bool[,] visited = new bool[maze.grid.GetLength(0), maze.grid.GetLength(1)];

            foreach (char move in moves)
            {
                visited[x, y] = true;

                switch(move)
                {
                    case 'U':
                        if (maze.grid[x, y].wallUp || visited[x,y - 1]) return false;
                        else y--;

                        break;
                    case 'D':
                        if (maze.grid[x, y].wallDown || visited[x, y + 1]) return false;
                        else y++;

                        break;
                    case 'L':
                        if (maze.grid[x, y].wallLeft || visited[x - 1, y]) return false;
                        else x--;

                        break;
                    case 'R':
                        if (maze.grid[x, y].wallRight || visited[x + 1, y]) return false;
                        else x++;

                        break;
                }
            }
            //if didn't walk into walls => move valid.
            return true;
        }

        static bool findEnd(Maze maze, string moves)
        {
            int x = maze.start[0];
            int y = maze.start[1];

            foreach (char move in moves)
            {
                switch (move)
                {
                    case 'U':
                       y--;
                        break;
                    case 'D':
                        y++;
                        break;
                    case 'L':
                        x--;
                        break;
                    case 'R':
                        x++;
                        break;
                }
            }

            if(maze.end[0] == x && maze.end[1] == y)
            {
                Console.WriteLine($"Shortest path to the end found : {moves}");
                maze.solution = moves;
                return true;
            }

            return false;
        }

    }
}
