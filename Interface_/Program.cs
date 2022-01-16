using System;

namespace Interface_
{
    class Program
    {
        static void Main(string[] args)
        {
            IGainedSpeed gainedSpeed = new TrafficObject();
            gainedSpeed.GainedSpeed(new Human());
            gainedSpeed.GainedSpeed(new Car());
        }
    }
}
