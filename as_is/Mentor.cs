using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace as_is
{
    class Mentor : Person
    {
        public uint NumberOfApprentice { get; private set; }

        public Mentor(string name, uint numberOfApprentice) : base(name)
        {
            NumberOfApprentice = numberOfApprentice;
        }
    }
}
