using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_
{
    class TrafficObject : IGainedSpeed
    {
        public void GainedSpeed(IMovable imovable)
        {
            Console.WriteLine(imovable + "\t" + imovable.GetSpeed());
            imovable.Move();
        }
    }
}
