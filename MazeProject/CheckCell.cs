using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProject
{
    public static class CheckCell
    {

        public static bool[] CheckConnection(int checkedX, int checkedY, Cell[,] grid)
        {
            bool[] connections = { false, false, false, false, false };  // indice : 0 up, 1 down, 2 left, 3 right, 4 is Connected ?

            if (checkedY - 1 >= 0)
            {
                if (grid[checkedX, checkedY - 1] != null) connections[0] = true;
            }
            if (checkedY + 1 < grid.GetLength(1))
            {
                if (grid[checkedX, checkedY + 1] != null) connections[1] = true;
            }

            if (checkedX - 1 >= 0)
            {
                if (grid[checkedX - 1, checkedY] != null) connections[2] = true;
            }
            if (checkedX + 1 < grid.GetLength(0))
            {
                if (grid[checkedX + 1, checkedY] != null) connections[3] = true;
            }


            // set connection[4] to know if cell is connected
            for (int i = 0; i < 4; i++)
            {
                if (connections[i]) connections[4] = true;
            }

            return connections;
        }


        public static bool[] CheckMove(int checkedX, int checkedY, Cell[,] grid)
        {

            //Console.WriteLine("Checking possible movement...");

            bool[] canMoveTo = { false, false, false, false, false }; // indice : 0 up, 1 down, 2 left, 3 right, 4 can move somewhere


            if (checkedY - 1 >= 0)
            {
                if (grid[checkedX, checkedY - 1] == null) canMoveTo[0] = true;
            }
            if (checkedY + 1 < grid.GetLength(1))
            {
                if (grid[checkedX, checkedY + 1] == null) canMoveTo[1] = true;
            }

            if (checkedX - 1 >= 0)
            {
                if (grid[checkedX - 1, checkedY] == null) canMoveTo[2] = true;
            }
            if (checkedX + 1 < grid.GetLength(0))
            {
                if (grid[checkedX + 1, checkedY] == null) canMoveTo[3] = true;
            }

            // set canMoveTo[4] to know if deplacement is possible
            for (int i = 0; i < 4; i++)
            {
                if (canMoveTo[i]) canMoveTo[4] = true;
            }

            return canMoveTo;

        }
    }
}
