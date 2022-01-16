using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_
{
    class Car : IMovable
    {
        public string GetSpeed()
        {
            return "60 км в час";
        }
    }
}
