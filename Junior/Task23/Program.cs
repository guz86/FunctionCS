﻿namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            // Работа со свойствами
            //     Создать класс игрока, у которого есть поля с его положением в x,y.
            // Создать класс отрисовщик, с методом, который отрисует игрока.
            //     Попрактиковаться в работе со свойствами.

            Point point = new Point(3, 5);
            Renderer renderer = new Renderer();
            renderer.Draw(point.X, point.Y);
        }
    }
}