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

            Battle battle = new Battle();
            Squad squad1 = battle.BattleSquads[0];
            Squad squad2 = battle.BattleSquads[1];
            battle.ShowSquads();

            // бой
            while (squad1.SquadLife() && squad2.SquadLife())
            {
                Thread.Sleep(1500);
                Random random = new Random();
                Soldier soldierShot2 = squad2.Soldiers[random.Next(0, squad2.Soldiers.Count)];
                Console.WriteLine($"Из {squad2.SquadName}  - {soldierShot2.Skill} стреляет");
                squad1.TakeDamage(soldierShot2.Damage);
                Thread.Sleep(1000);
                if (squad1.SquadLife())
                {
                    Soldier soldierShot1 = squad1.Soldiers[random.Next(0, squad1.Soldiers.Count)];
                    Console.WriteLine($"Из {squad1.SquadName}  - {soldierShot1.Skill} стреляет");
                    squad2.TakeDamage(soldierShot1.Damage);
                }
                battle.ShowSquads();
            }

            if (squad1.SquadLife()) Console.WriteLine($"Победил {squad1.SquadName}");

            if (squad2.SquadLife()) Console.WriteLine($"Победил {squad2.SquadName}");
        }
    }
}