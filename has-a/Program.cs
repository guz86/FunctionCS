using System;

namespace has_a
{
    class Program
    {
        static void Main(string[] args)
        {
            // связь объектов. Система задач: список задач, задача, пользователь
            User userOne = new User("Иван");
            User userTwo = new User("Сергей");

            string workOne = "Собрать документы";
            string workTwo = "Отправить документы";

            Task taskOne = new Task(userOne, workOne);
            Task taskTwo = new Task(userTwo, workTwo);

            List list = new List(new Task[] { taskOne, taskTwo });

            //List list = new List(new Task[] { new Task(userOne, "Собрать документы"), new Task(userTwo, "Отправить корреспонденцию") });
            Console.ReadKey();
        }

        class User
        {
            public string Name;
            public User(string name)
            {
                Name = name;
            }
        }

        // задача, ссылается на пользоваетеля, кто делает
        class Task
        {
            public User Worker;
            public string Description;

            public Task(User worker, string discription)
            {
                Worker = worker;
                Description = discription;
            }

        }

        // массив задач
        class List
        {
            public Task[] Tasks;

            public List(Task[] tasks)
            {
                Tasks = tasks;
            }

        }



    }
}
