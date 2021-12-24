using System;

namespace virtual_method
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class NPS
    {
        public void ShowInfo()
        {
            Console.WriteLine("Я ничего не делаю.");
        }
    }

    class Farmer : NPS
    {

    }

    class Warrior : NPS
    {

    }

    class Child : NPS
    {

    }
}
