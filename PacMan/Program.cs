using System;
using System.IO;

namespace PacMan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;


            bool isPlaying = true;

            int pacmanX, pacmanY;
            int pacmanDX = 0, pacmanDY = 1;

            char[,] map = ReadMap("map1", out pacmanX, out pacmanY);

            DrawMap(map);

            while (isPlaying)
            {
                Console.SetCursorPosition(pacmanY, pacmanX);
                Console.Write('@');

                // без символов
                //Console.ReadKey(true);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        
                        case ConsoleKey.LeftArrow:
                            pacmanDX = 0; pacmanDY = -1;
                            break;
                        case ConsoleKey.UpArrow:
                            pacmanDX = -1; pacmanDY = 0;
                            break;
                        case ConsoleKey.RightArrow:
                            pacmanDX = 0; pacmanDY = 1;
                            break;
                        case ConsoleKey.DownArrow:
                            pacmanDX = 1; pacmanDY = 0;
                            break;
                        default:
                            break;
                    }
                }
                if (map[pacmanX+ pacmanDX, pacmanY + pacmanDY] != '#')
                {
                    Console.SetCursorPosition(pacmanY, pacmanX);
                    Console.Write(" ");
                    pacmanY += pacmanDY;
                    pacmanX += pacmanDX;
                    Console.SetCursorPosition(pacmanY, pacmanX);
                    Console.Write("@");
                }
                System.Threading.Thread.Sleep(200);
            }


        }
        // функция считывает готовую карту из файла
        static char[,] ReadMap(string mapName, out int packmanX, out int packmanY)
        {
            //инициализация для работы
            packmanX = 0;
            packmanY = 0;
            string[] newFile = File.ReadAllLines($"Maps/{mapName}.txt");
            // newFile.Length количество строчек
            // newFile[0].Length - длина первой строчки
            // содздаем карту и переносим в нее данные с файла
            char[,] maps = new char[newFile.Length, newFile[0].Length];

            for (int i = 0; i < maps.GetLength(0); i++)
            {
                for (int j = 0; j < maps.GetLength(1); j++)
                {
                    maps[i, j] = newFile[i][j];
                    if (maps[i, j] == '@')
                    {
                        packmanX = i;
                        packmanY = j;
                    }
                }
            }
            return maps;
        }

        // отрисовываем карту
        static void DrawMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }


    }
}
