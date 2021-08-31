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
            bool isALive = true;

            // enemy

            int ghostX; int ghostY;
            int ghostDX = 0, ghostDY = -1;
            Random random = new Random();


            int allDots = 0;
            int collectDots = 0;

            char[,] map = ReadMap("map1", out pacmanX, out pacmanY, out ghostX, out ghostY, ref allDots);

            DrawMap(map);

            while (isPlaying)
            {
                Console.SetCursorPosition(0, 20);
                Console.Write($"Box: {collectDots}/{allDots}");
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
                    CollectDots(map, pacmanX, pacmanY, ref collectDots);
                    Move(map, '@', ref pacmanX, ref pacmanY, pacmanDX, pacmanDY);

                }
                // enemy
                if (map[ghostX + ghostDX, ghostY + ghostDY] != '#')
                {
                    Move(map, '$', ref ghostX, ref ghostY, ghostDX, ghostDY); 
                }
                else
                {
                    ChangeDirection(random, ref ghostDX, ref ghostDY);
                }

                if (ghostX==pacmanX && ghostY == pacmanY)
                {
                    isALive = false;
                }


                System.Threading.Thread.Sleep(100);

                if (collectDots == allDots || isALive == false)
                {
                    isPlaying = false;
                }

            }
            if (collectDots == allDots)
            {

                Console.SetCursorPosition(0, 21);
                Console.WriteLine("Победа");
            }
            else if (!isALive)
            {

                Console.SetCursorPosition(0, 21);
                Console.WriteLine("Поражение");
            }

        }
        // функция считывает готовую карту из файла
        static char[,] ReadMap(string mapName, out int packmanX, out int packmanY, out int ghostX, out int ghostY, ref int allDots)
        {
            //инициализация для работы
            packmanX = 0;
            packmanY = 0;

             ghostX = 0;  ghostY = 0;

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
                        maps[i, j] = '.';
                    }
                    else if (maps[i, j] == '$')
                    {
                        ghostX = i;
                        ghostY = j;
                        maps[i, j] = '.';
                    }
                    else if (maps[i, j] == ' ')
                    {
                        maps[i, j] = '.';
                        allDots++;
                    }
                }
            }
            return maps;
        }

        // движение
        static void Move(char [,] map, char symbol, ref int X, ref int Y, int DX, int DY)
        {
            Console.SetCursorPosition(Y, X);
            Console.Write(map[X,Y]);

            Y += DY;
            X += DX;

            Console.SetCursorPosition(Y, X);
            Console.Write(symbol);
        }

        // собираем точки
        static void CollectDots(char [,] map, int pacmanX, int pacmanY,ref int collectDots)
        {
            if (map[pacmanX, pacmanY] == '.')
            {
                map[pacmanX, pacmanY] = ' ';
                collectDots++;
            }
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

        // enemy выбор направления для движения
        static void ChangeDirection(Random random, ref int DX, ref int DY)
        {
            int ghostDir = random.Next(1, 5);
            switch (ghostDir)
            {

                case 1:
                    DX = 0; DY = -1;
                    break;
                case 2:
                    DX = -1; DY = 0;
                    break;
                case 3:
                    DX = 0; DY = 1;
                    break;
                case 4:
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
