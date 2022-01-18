using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Human
    {
        public void Move(Vehicle vehicle)
        {
            vehicle.ShowInfo();
            vehicle.Move();
            
        }
    }
}
