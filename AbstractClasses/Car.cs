using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Car : Vehicle
    {
        public override int Speed { get { return 60; } }

        public override void Move()
        {
            Console.WriteLine(" поехала");
        }
    }
}
