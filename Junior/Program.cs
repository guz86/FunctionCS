using System;

namespace Junior
{
    class Program
    {
        // Функции - как передовать обычные данные как передовать массивы
        static void Main(string[] args)
        {
            Console.WriteLine("Привет");

            // WriteError("Ошибка. Нет интернета.", ConsoleColor.Red);
            WriteError("Ошибка. Нет интернета.", symbol: '!');

            Console.WriteLine("Не может быть");
            // в функцию из программы передается аргумент "Оплати интернет"
            // WriteError("Оплати интернет", ConsoleColor.Red);
            WriteError("Оплати интернет", ConsoleColor.Yellow);

            // функция с возвращаемыми значениями
            //Console.WriteLine(Sum(4, 5) );
            int l = 5, u = 3, sum;
            sum = Sum(l, u) + l + u;
            Console.WriteLine(sum + " " + Sum(u, l));

            Console.WriteLine("-------------");

            //int uSum = 0, uX = 2, uY = 3;

            // если мы оставляем uSum без инициализации используем out
            int uSum, uX = 2, uY = 3;

            // при !ref uSum! требуется обязательно проинициализировать переменную  int uSum = 0  

            // MySum(uSum, uX, uY);
            // 0

            //MySum(ref uSum, uX, uY);

            //out - обязует самостоятельно проиниализировать переменную

            MySum(out uSum, uX, uY);

            Console.WriteLine(uSum);

            Console.WriteLine("-------------");

            int[]  myArray = new int [5];
            // передаем ссылку на область памяти
            // EditArray(myArray, 2, 5);

            myArray = EditArray(myArray, 2, 10);
            Console.WriteLine(myArray[2]);



            Console.WriteLine("-------------");
            int[] myArrayResize = new int[5];
            int[,] myArrayResizeTwo = new int[5, 5];

            myArrayResize = ResizeArray(myArrayResize, 10);
            myArrayResizeTwo = ResizeArray(myArrayResizeTwo, 10, 10);


        }
        // передаем параметр в функцию , что хотим получить string text
        // void пустота
        // static void WriteError(string text)
        // static void WriteError(string text, ConsoleColor color)
        // необезательные параметры ставятся в конце
        static void WriteError(string text, ConsoleColor color = ConsoleColor.Red, char symbol = '#')
        {
            // запомним в переменную текущий цвет текста в консли
            ConsoleColor defaulColor = Console.ForegroundColor;
            // сообщение выводится красным
            Console.ForegroundColor = color;

            Console.WriteLine(symbol + text);

            // возвращаем текущий цвет
            Console.ForegroundColor = defaulColor;
        }
        // параметры х у
        static int Sum(int x, int y)
        {
            int sum;
            sum = x + y;
            return sum;
            return x;

        }


        //
        // ref out -  когда нужно вернуть из функции больше 1 значения
        // как данные передаются в функцию
        // ref - передаем не переменную, а ссылку на область памяти где храниться переменная
        //static void MySum(int sum, int x, int y)
        //static void MySum(ref int sum, int x, int y)
        static void MySum(out int sum, int x, int y)
        {
            sum = x + y;

        }

        // функция модицифирует массив
        static int[] EditArray(int[] array, int index, int value)
        {
            // пересоздаем массив
            array = new int[6];
            array[index]= value;
            // возвращаем массив чтобы передать расширенный
            return array;
        }

        // пересоздаем массив с новым размером // recreate an array with a new size
        /// <summary>
        /// Migrate data to a new array
        /// </summary>
        /// <param name="array">Array</param>
        /// <param name="size">Size new Array</param>
        /// <returns>New Size Array</returns>
        static int[] ResizeArray (int[] array, int size)
        {   
            int[] tempArray = new int[size];
            // переносим данные в новый временный массив // migrate data to a new array
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            array = tempArray;
            return array;
        }

        static int[,] ResizeArray (int[,] array, int x, int y)
        {
            int[,] tempArray = new int[x,y];
            // переносим данные в новый временный массив // migrate data to a new array
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    tempArray[i,j] = array[i,j];
                }
            }
            array = tempArray;
            return array;
        }

    }
}
