using System;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // структура становиться классом - Boxing упаковка
            int i = 100;
            // неявно из структуры сделали объект
            object o = i;

            i = 10;
            Console.WriteLine(i);
            // при помощи явного приведения типов  - Unboxing распаковка
            i = (int)o;
        }
    }
}
