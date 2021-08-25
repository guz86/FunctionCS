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

                    ChangeDirection(key, ref pacmanDX, ref pacmanDY);

                }
                if (map[pacmanX+ pacmanDX, pacmanY + pacmanDY] != '#')
                {
                    Move(ref pacmanX, ref pacmanY, pacmanDX,pacmanDY);
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

        // движение
        static void Move(ref int X, ref int Y, int DX, int DY)
        {
            Console.SetCursorPosition(Y, X);
            Console.Write(" ");

            Y += DY;
            X += DX;

            Console.SetCursorPosition(Y, X);
            Console.Write("@");
        }

        // выбор направления для движения
        static void ChangeDirection(ConsoleKeyInfo key, ref int DX, ref int DY)
        {
            switch (key.Key)
            {

                case ConsoleKey.LeftArrow:
                    DX = 0; DY = -1;
                    break;
                case ConsoleKey.UpArrow:
                    DX = -1; DY = 0;
                    break;
                case ConsoleKey.RightArrow:
                    DX = 0; DY = 1;
                    break;
                case ConsoleKey.DownArrow:
                    DX = 1; DY = 0;
                    break;
                default:
                    break;
            }
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
