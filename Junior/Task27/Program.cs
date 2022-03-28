namespace Task27
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int chooseAttack;
            //Fighter mag = new Mag("Magusso", random.Next(700,900), random.Next(45,60));
            //Fighter warrior = new Warrior("WarrioOOOR", random.Next(1200,1500), random.Next(60,100));
            //Fighter healer = new Healer("HealerYoda", random.Next(600,900), random.Next(20,50));
            //Fighter necro = new Necromant("Necro", random.Next(600,900), random.Next(50,70));
            //Fighter superman = new Superman("Твердыня", random.Next(600,900), random.Next(50,70));

            string[] generateNameMag = {"Magusso", "MagGG","Magila"};
            string[] generateNameWarrior = {"Warr", "WarrGG","Warrila"};
            string[] generateNameHealer = {"HealerYoda", "HealerGG","Healerila"};
            string[] generateNameNecromant = {"Necromanto", "NecromantGG","Necromantila"};
            string[] generateNameSuperman = {"Твердыня", "ТвердыняGG","Твердынин"};
            
            Fighter[] fighters =
            {
                new Mag(generateNameMag[random.Next(0,3)], random.Next(700, 900), random.Next(45, 60)),
                new Warrior(generateNameWarrior[random.Next(0,3)], random.Next(1200, 1500), random.Next(60, 100)),
                new Healer(generateNameHealer[random.Next(0,3)], random.Next(600, 900), random.Next(20, 50)),
                new Necromant(generateNameNecromant[random.Next(0,3)], random.Next(600, 900), random.Next(50, 70)),
                new Superman(generateNameSuperman[random.Next(0,3)], random.Next(600, 900), random.Next(50, 70))
            };
            
            Fighter fightersLeft = fighters[random.Next(0, 5)];
            Fighter fightersRight = fighters[random.Next(0, 5)];

            Console.WriteLine("---------------");
            fightersLeft.ShowStats();
            fightersRight.ShowStats();
            Console.WriteLine("---------------");

            while (fightersLeft.isAlive() && fightersRight.isAlive())
            {
                Console.WriteLine("\n....Подготовка к атакам....\n");
                chooseAttack = random.Next(1, 3);
                Thread.Sleep(1500);
                if (chooseAttack == 1)
                {
                    fightersLeft.TakeDamage(fightersRight.Damage);
                    fightersRight.TakeDamage(fightersLeft.Damage);
                }
                else
                {
                    Console.WriteLine("Противники готовят уникальные способности:");
                    fightersLeft.TakeDamage(fightersRight.UniqueAbility());
                    fightersRight.TakeDamage(fightersLeft.UniqueAbility());
                }
            }

            if (!fightersLeft.isAlive() && !fightersRight.isAlive())
            {
                Console.WriteLine($"\n{fightersLeft.Name} и {fightersRight.Name} погибли");
            }
            else if (!fightersLeft.isAlive())
            {
                Console.WriteLine($"\n{fightersLeft.Name} погиб");
            }
            else if (!fightersRight.isAlive())
            {
                Console.WriteLine($"\n{fightersRight.Name} погиб");
            }
        }
    }
}