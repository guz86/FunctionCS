using System;
using System.Threading;

namespace UpcastingDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person;
            Mentor mentor1 = new Mentor("Alexey", 11);

            Console.WriteLine(mentor1.NumberOfApprentice);
            Console.WriteLine("----");
            // восходящее преобразование
            // один и тот же объект в памяти
            person = mentor1;
            person.ShowInfo();
            //person.NumberOfApprentice сокрыт

            // нисходящее преобразование явное
            Mentor mentor2 = (Mentor)person;
            mentor2.ShowInfo();
            Console.WriteLine(mentor2.NumberOfApprentice);


            Console.WriteLine("----");

            Person person1 = new Apprentice("Roman", 6);

            Person person3;
            person3 = person1;
            person1.ShowInfo();

            Apprentice apprentice;
            apprentice = (Apprentice)person3;
            Console.WriteLine("ApprenticeScore " + apprentice.ApprenticeScore);


            Person person2 = new Mentor("David", 4);
            person2.ShowInfo();
            Mentor mentor;
            mentor = (Mentor)person2;

            Console.WriteLine("NumberOfApprentice "+mentor.NumberOfApprentice);


        }
    }
}
