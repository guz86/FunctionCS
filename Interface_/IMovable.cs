using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_
{
    interface IMovable
    {
        string GetSpeed();
        void Move()
        { // реализация по-умолчанию. спорно, смешиваем абстракцию и реализацию
            Console.WriteLine("Moving");
        }
        
    }
}
