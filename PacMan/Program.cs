using System;
using System.IO;

namespace PacMan
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] map;
        }
       // функция считывает готовую карту из файла
       static char [,] ReadMap(string mapName)
        {
            string[] newFile = File.ReadAllLines($"Maps/{mapName}.txt");
            char[,] maps = new char[1,1];

            return maps;

        }


    }
}
