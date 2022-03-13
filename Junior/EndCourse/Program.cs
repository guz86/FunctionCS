using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace EndCourse
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //// 1 Value Types and Reference Types
            
            //Value Types (в куче) в стеке  - при передаче передается копия значения переменной
            //    -числовые, bool, пользовательские структуры

            //Reference Types - в куче - при передаче передается ссылка на значение
            //    -классы, делегаты, интерфейсы, dynamic, object, String, Массивы
            
            // 1
            int a = 2;
            int b = 4;
            a = b;
            b = 6;
            Console.WriteLine($"{a}, {b}"); // 4 6  происходит копирование значения
            
            // 2
            int value1 = 10, value2 = 15, value3 = 20;
            Sum(value1,value2,value3); // value3 не связана с параметром value3
            Console.WriteLine(value3); // 20 
            
            // 3
            SumValue3(value1,value2,ref value3);
            Console.WriteLine(value3); // 25 передача по ссылке 
            
            // 4
            int[] array1 = {1, 2, 3};
            int[] array2 = array1; // копируется ссылка на массив
            array2[0] = 5;
            Console.WriteLine(array1[0]); // 5 , обе переменные ссылаются на один и тот же массив

            // 5
            int[] array = {1, 22, 33, 445};
            Change(array); // в метод передается ссылка на массив и в нем производятся изменения
            Console.WriteLine(array[0]); // 99
            
            // 6
            // array {99,22,33,445}
            ChangeNew(array); // в локальную переменную помещается ссылка на новый массив, мы вносим в него изменения
            Console.WriteLine(array[0]); // 99 , array никак не затрагивается
            
            // 7
            // array {99,22,33,445}
            ChangeNewRef(ref array); // создается новый массив на 5 элементов и первое значение 88
                                     // и он передается по ссылки в array
            Console.WriteLine(array[0]); // 88

            
            //// 2 Интернирование строк
            
            


            // 6
            string message = "";
            for (int i = 0; i < 10; i++)
            {
                message += i.ToString();
            }

            Console.WriteLine(message);
    
        }
        // 1 / 2
        static void Sum(int value1, int value2, int value3)
        {
            value3 = value1 + value2;
        }
        // 1 / 3
        static void SumValue3(int value1, int value2, ref int value3)
        {
            value3 = value1 + value2;
        }
        
        
        // 1 / 5
        static void Change(int[] array)
        {
            array[0] = 99;
        }
        // 1 / 6
        static void ChangeNew(int[] array)
        {
            array = new int[3];
            array[0] = 66;
        }
        // 1 / 7
        static void ChangeNewRef(ref int[] array)
        {
            array = new int[5];
            array[0] = 88;
        }
    }
}