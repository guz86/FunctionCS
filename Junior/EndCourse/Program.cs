using System;
using System.Runtime.InteropServices;

namespace EndCourse
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Value Types and Reference Types
            
            //Value Types (в куче) в стеке  - при передаче передается копия значения переменной
            //    -числовые, bool, пользовательские структуры

            //Reference Types - в куче - при передаче передается ссылка на значение
            //    -классы, делегаты, интерфейсы, dynamic, object, String, Массивы
            
            //1
            int a = 2;
            int b = 4;
            a = b;
            Console.WriteLine($"{a}, {b}"); // 4 4  происходит копирование значения
            
            
            
            


            // 6
            string message = "";
            for (int i = 0; i < 10; i++)
            {
                message += i.ToString();
            }

            Console.WriteLine(message);
    
        }
    }
}