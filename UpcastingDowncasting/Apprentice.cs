using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting
{
    class Apprentice : Person
    {
        public uint ApprenticeScore { get; private set; }
        public Apprentice(string name, uint apprenticeScore) : base(name)
        {
            ApprenticeScore = apprenticeScore;
        }

    }
}
