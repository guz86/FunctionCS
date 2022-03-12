using System;

namespace EndCourse
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            
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