using System;

namespace virtual_method
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array  = new int[4];
              NPS[] players = new NPS[] {new NPS(), new Farmer(), new Warrior(), new Child()};

            foreach (var player in players)
            {
                player.ShowInfo();
                Console.WriteLine(" ");
            }
        }
    }

    class NPS
    {
        public virtual void ShowInfo()
        {
            Console.WriteLine("Я ничего не делаю.");
        }
    }

    class Farmer : NPS
    {
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Пойду поработаю.");
        }
    }

    class Warrior : NPS
    {
        public override void ShowInfo()
        {
            Console.WriteLine("Пойду потренируюсь, скоро в бой");
        }

    }

    class Child : NPS
    {

    }
}
