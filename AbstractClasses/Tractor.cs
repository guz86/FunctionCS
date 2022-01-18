using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Tractor : Vehicle
    {
        public override int Speed { get { return 30; } }

        public override void Move()
        {
            Console.WriteLine(" едет");
        }
    }
}
