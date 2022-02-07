using System;

namespace as_is
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ivan");
            Person person1 = new Mentor("Alexey",10);

            //System.InvalidCastException: 'Unable to cast object of type
            //'as_is.Person' to type 'as_is.Mentor'.'
            //Mentor mentor = (Mentor)person;

            Mentor mentor = (Mentor)person1;

            Mentor mentor1 = person as Mentor;
            // mentor1 null

            Mentor mentor2 = person1 as Mentor;
            mentor2.ShowInfo();

            // простая проверка перед преобразованием

            if (person1 is Mentor)
            {
                Mentor mentor3 = (Mentor)person1;
                mentor3.ShowInfo();
            }

            // если да то передаем в mentor4

            if (person1 is Mentor mentor4)
            {
                mentor4.ShowInfo();
            }

        }
    }
}
