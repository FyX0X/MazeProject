using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProject
{
    [Serializable]
    public class Maze
    {
        public Cell[,] grid;
        public int[] start;
        public int[] end;
        public string solution;

        public Maze(Cell[,] _grid)
        {

            grid = _grid;

            start = new int[] {0, 0};
            end = new int[] {grid.GetLength(0)-1, grid.GetLength(1)-1};
        }
    }
}
