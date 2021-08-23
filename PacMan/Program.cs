using System;
using System.IO;

namespace PacMan
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] map = ReadMap("map1");
        }
       // функция считывает готовую карту из файла
       static char [,] ReadMap(string mapName)
        {
            string[] newFile = File.ReadAllLines($"Maps/{mapName}.txt");
            // newFile.Length количество строчек
            // newFile[0].Length - длина первой строчки
            // содздаем карту и переносим в нее данные с файла
            char[,] maps = new char[newFile.Length,newFile[0].Length];

            for (int i = 0; i < maps.GetLength(0); i++)
            {
                for (int j = 0; j < maps.GetLength(1); j++)
                {
                    maps[i, j] = newFile[i][j];
                }
            }


            return maps;

        }


    }
}
