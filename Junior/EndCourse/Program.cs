﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Threading;

namespace EndCourse
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            #region First

            

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

            #endregion
            
            //// ООП, если есть класс с которого мы можем создать объект в котором заключено
            // состояние и методы с которыми мы можем взаимодействовать
            // Абстракция - отделение несущественного от существенного(абстрагируемся от конкретики в сущностях, обобщение)
            // Инкапсуляция - некое поле(данные) и некий метод(операции) заключены в объекте, и защищаем данный объект
            // от не правильного использования (про сокрытие)
            // Наследование - борьба с дублирующимся кодом в классах, общий случай и уточнения (любая кошка животное,
            // но не любое животное кошка, но некоторые животные это кошки, у них усы)
            // Полиморфизм - (полиморфизм подтипов) Один интерфейс, множество реализаций
            // для ООП нужен класс, объект: конструктор, с полями(свойствами) и методами

            // 1
            
            string trader1 = "Trader1";
            string trader2 = "Trader2";
            string[] goods1 = {"Board", "Pensil", "Paper"};
            string[] goods2 = {"Skate", "Helmet", "Shirt"};
            
            Console.WriteLine($"{trader1}:");
            foreach (var good in goods1)
            {
                Console.Write($"{good} ");
            }
            
            Console.WriteLine($"\n{trader2}:");
            foreach (var good in goods2)
            {
                Console.Write($"{good} ");
            }

            Console.WriteLine();
            // проблемы с добавлением следущего торговца, дублирование кода
            
            // 2
            
            // упрощаем, для добавления нового traider добавляем в массивы его и список его товаров
            string[] traders = {"Trader1", "Trader2"};
            string[][] goods =
            {
                new string[]
                {
                    "Board",
                    "Pensil",
                    "Paper"
                },
                new string[]
                {
                    "Skate",
                    "Helmet",
                    "Shirt"
                }
            };

            for (int i = 0; i < traders.Length; i++)
            {
                Console.WriteLine($"\n{traders[i]}:");
                foreach (var good in goods[i])
                {
                    Console.Write($"{good} ");
                }
            }
            
            // не контролируем целостность, можем добавить торговца но не добавить список его товаров
            // не выделены сущности торговец и его товары
            Console.WriteLine();
            
            // 3
            // выделяем отдельный класс Trader
            Trader[] myTraders =
            {
                new Trader(
                    "Traider1",
                    new string[]
                    {
                        "Board",
                        "Pensil",
                        "Paper"
                    }
                ),
                new Trader(
                    "Traider2",
                    new string[]
                    {
                        "Skate",
                        "Helmet",
                        "Shirt"
                    }
                )
            };

            foreach (var trader in myTraders)
            {
                Console.WriteLine($"\n{trader.Name}:");
                foreach (var good in trader.Goods)
                {
                    Console.Write($"{good} ");
                }
            }
            
            // без доп валидации

             
            
            
            //задача посчитать разность всех элементов через while
            /*List<int> list = new List<int>(){1, 2, 3, 100};
            
            int iter = 1;
            int result = list[0];
            
            while (iter < list.Count)
            {
                result -= list[iter];
                iter++;
            }

            Console.WriteLine(result);*/
            Console.WriteLine();
            
        // InSequence
        IntSequence sequence = new IntSequence(1,2,3,4,5,6,7,8,9);
        sequence.Index = -1;
        while (sequence.Next())
        {
            Console.Write(sequence.Array[sequence.Index]);
        }

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

        #region If и Switch

        
        // Избавляемся от If и Switch
    
        public static void Attack(int attackType)
        {
            if (attackType == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Attack 0");
            }
            else if (attackType == 1)
            {
                Console.ForegroundColor  = ConsoleColor.Green;
                Console.WriteLine("Attack 1");
            }
            else if (attackType == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Attack 2");
            }
        }
        
        // или
        public static void Attack2(int attackType)
        {
            switch (@attackType)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Attack 0");
                    break;
                case 1:
                    Console.ForegroundColor  = ConsoleColor.Green;
                    Console.WriteLine("Attack 1");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Attack 2");
                    break;
            }
        }
        
        // дублирование кода
        // при изменении формата вывода, придется менять его в каждом case
        
        // рефакторинг, извлечение метода
        
        public static void AttackA(int attackType)
        {
            if (attackType == 0)
            {
                ShowInfoAttack("Attack 0", ConsoleColor.Blue);
            }
            else if (attackType == 1)
            {
                ShowInfoAttack("Attack 1", ConsoleColor.Green);
            }
            else if (attackType == 2)
            {
                ShowInfoAttack("Attack 2", ConsoleColor.Red);
            }
        }

        private static void ShowInfoAttack( string description, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(description);
        }
        
        // не избавились от условной логики

        public static Item [] items =
        {
            new Item("Attack 0", ConsoleColor.Blue),
            new Item("Attack 1", ConsoleColor.Green),
            new Item("Attack 2", ConsoleColor.Red),
        };
        
        
        public static void AttackB(int itemId)
        {
            
            //items[itemId].ShowInfoAttackB();
            ShowInfoAttackB(items[itemId].Description,items[itemId].Color);
        }

        private static void ShowInfoAttackB( string description, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(description);
        }
 

        public class Item
        {
            public string Description;
            public ConsoleColor Color;
            
            public Item(string description, ConsoleColor color)
            {
                Color = color;
                Description = description;
            }
            
            // public void ShowInfoAttackB()
            // {
            //     Console.ForegroundColor = Color;
            //     Console.WriteLine(Description);
            // }
            //
        }
        
        #endregion
        
        ////  инкапсуляция
        // 1
        class Timer
        {
            public int Start;
            public int End;
            
            public Timer(int start, int end)
            {
                Start = start;
                End = end;
            }
        }
        
        // можем изменять поля как угодно
        // 1-3

        #region Timer

        class Timer2
        {
            private int _start;
            private int _end;
            
            public Timer2(int start, int end)
            {
                _start = start;
                _end = end;
            }

            public void SetStart(int start)
            {
                // защищаем
                if (start > _end) throw new ArgumentException("start");
                _start = start;
            }

            public int GetStart()
            {
                return _start;
            }
            
            public void SetEnd(int end)
            {
                if (end < _start) throw new ArgumentException("end");
                _end = end;
            }

            public int GetEnd()
            {
                return _end;
            }
            
        }
        
        #endregion
        
        // где нарушается инкапсуляция
        // IntSequence
        class IntSequence
        {
            public int Index;
            public int[] Array;
            
            public IntSequence(params int[] array)
            {
                Array = array;
            }

            public bool Next()
            {
                Index++;
                if (Index >=Array.Length)
                {
                    Index = 0;
                    return false;
                }
                return true;
            }
            
            
        }
    }
    #region 3

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
    
    #endregion
}