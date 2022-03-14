using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Threading;

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
            // строка ссылочный тип, но не изменяемый
            // Object.Equals - переопределен на посимвольное сравнение в строках
            // Object.ReferenceEquals - сравнивает ссылки
            
            // 1
            string messageHello = "hello hello hello";
            for (int i = 0; i < messageHello.Length; i++)
            {
                Thread.Sleep(100);
                Console.Write(messageHello[i]);
            }
            Console.WriteLine();
            
            // 2 messageHello[0] = 's'; - нельзя менять символ, из-за оптимизации по тексту
            
            // 3
            messageHello = messageHello.ToUpper(); // метод возвращает измененую копию строки
            Console.WriteLine(messageHello);
            
            // 4 
            string str1 = "Hello";
            string str2 = "He"+"llo";
            string str3 = string.Format("{0}{1}","He","llo"); // по-символьно та же строка, новая строка в куче
            Console.WriteLine(str1+str2+str3);
            Console.WriteLine("str1 str2 " + Object.ReferenceEquals(str1,str2)); // str1 str2 True
            Console.WriteLine("str1 str3 " + Object.ReferenceEquals(str1,str3)); // str1 str3 False
            Console.WriteLine("str2 str3 " + Object.ReferenceEquals(str2,str3)); // str2 str3 False
            
            // 5
            // сравнение посимвольно
            Console.WriteLine("str1 str2 " + Object.Equals(str1,str2)); // str1 str2 True
            Console.WriteLine("str1 str3 " + Object.Equals(str1,str3)); // str1 str3 True
            Console.WriteLine("str2 str3 " + Object.Equals(str2,str3)); // str2 str3 True
            
            // сравнение строк без учета регистра идет быстрее
            
            // сравнение посимвольно
            Console.WriteLine("str1 str2 " + (str1 == str2)); // str1 str2 True
            Console.WriteLine("str1 str3 " + (str1 == str3)); // str1 str3 True
            Console.WriteLine("str2 str3 " + (str2 == str3)); // str2 str3 True

            // 6
            string message = "";
            for (int i = 0; i < 10; i++)
            {
                message += i.ToString(); //каждый раз создается копия строки при конкатенации,
                                         //i.ToString тоже создаст копию строки
            }
            Console.WriteLine(message);
            // проблема решается классом  StringBuilder
            
            // 7 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Decorate("Hello","b")); 
            }
            
            //// 3 Статика
            
            // 1
            Console.WriteLine("Hi");
            SomeClass someClass = new SomeClass();
            Console.WriteLine(SomeClass.StaticField);
            // Hi
            // Static ctor
            // ctor
            // 10

        }

        #region 1

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
        #endregion
        
        #region 2

        // 2 / 7
        private static string Decorate(string text, string tag)
        {
            // return $"<{tag}>{text}</{tag}>"; // все созданные объекты ссылаются
            // на разные участки в памяти(разные экземпляры) return $"<{tag}>{text}</{tag}>";
            return string.Intern($"<{tag}>{text}</{tag}>"); // при дублировании возвращается ссылка из пула, либо в пул добавляется новая строчка, если она отличается
        }

        #endregion
        

    }

    // 3 / 1
    class SomeClass
    {
        public static float StaticField;

        static SomeClass()
        {
            StaticField = 10;
            Console.WriteLine("Static ctor");
        }

        public SomeClass()
        {
            Console.WriteLine("ctor");
            
        }
    }
}