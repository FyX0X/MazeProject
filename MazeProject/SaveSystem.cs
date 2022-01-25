using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MazeProject
{
    public static class SaveSystem
    {

        public static void SaveMaze(Maze maze, string filePath)
        {
            BinaryFormatter bf = new BinaryFormatter();
            string path = getNextFileName($@"{filePath}\maze({maze.grid.GetLength(0)}x{maze.grid.GetLength(1)})Data0.maze");


            FileStream stream = new FileStream(path, FileMode.Create);
            bf.Serialize(stream, maze);
            stream.Close();
        }

        public static Maze LoadMaze(string filePath)
        {
            BinaryFormatter bf = new BinaryFormatter();
            string path = filePath;
            FileStream stream = new FileStream(path, FileMode.Open);
            Maze mazeData = bf.Deserialize(stream) as Maze;
            stream.Close();

            return mazeData;
        }

        private static string getNextFileName(string fileName)
        {
            string extension = Path.GetExtension(fileName);

            int i = 0;
            while (File.Exists(fileName))
            {
                fileName = fileName.Replace(i + extension, ++i + extension);
            }

            return fileName;
        }
    }
}