namespace Task29
{
    class Program
    {
        static void Main()
        {
            /*
            Война
                Есть 2 взвода. 1 взвод страны один,  2 взвод страны два.Каждый взвод внутри
                имеет солдат.Нужно написать программу, которая будет моделировать бой
                этих взводов.Каждый боец - это уникальная единица, он может иметь уникальные способности или
                же уникальные характеристики, такие как повышенная сила.Побеждает та страна, во взводе которой остались
                выжившие бойцы.Не важно, какой будет бой, рукопашный, стрелковый.
            */
            Squad squad1 = new Squad();
            Squad squad2 = new Squad();
            squad1.SquadName = "Gaga";
            squad2.SquadName = "Saga";

            squad1.AddSoldiers();
            squad2.AddSoldiers();

            // бой
            while (squad1.SquadLife() && squad2.SquadLife())
            {
                Thread.Sleep(1500);
                Random random = new Random();
                if (squad2.SquadLife())
                {
                    squad1.TakeDamage(squad1.Soldiers[random.Next(0, squad2.Soldiers.Count)].Damage);
                }

                Thread.Sleep(1000);
                if (squad1.SquadLife())
                {
                    squad2.TakeDamage(squad2.Soldiers[random.Next(0, squad1.Soldiers.Count)].Damage);
                }
            }

            if (squad1.SquadLife()) Console.WriteLine($"Победил squad1");

            if (squad2.SquadLife()) Console.WriteLine($"Победил squad2");
        }
    }
}