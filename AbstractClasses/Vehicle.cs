using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    abstract class Vehicle
    {
        //protected float Speed;
        public abstract int Speed { get;  }
        public abstract void Move();
        public float GetCurrentSpeed()
        {
            return Speed;
        }

        public void ShowInfo()
        {
            Console.Write($"Скорость {Speed} => "+GetType().Name);
        }

    }
}
