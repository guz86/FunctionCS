using System;

namespace has_a
{
    class Program
    {
        static void Main(string[] args)
        {
           // связь объектов. Система задач: список задач, задача, пользователь

        }

        class User
        {
            public string Name;
            public User(string name)
            {
                Name = name;
            }
        }

        // задача
        class Task
        {
            //public string User;

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
