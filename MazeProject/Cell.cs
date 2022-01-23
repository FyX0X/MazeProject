using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProject
{
    [Serializable]
    public class Cell
    {
        //wall
        public bool wallUp = true;
        public bool wallDown = true;
        public bool wallLeft = true;
        public bool wallRight = true;


    }
}
