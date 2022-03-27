namespace Task27
{
    class Program
    {
        static void Main()
        {
            // Гладиаторские бои
            // Создать 5 бойцов, пользователь выбирает 2 бойцов и они сражаются друг с другом до смерти. У каждого бойца
            //     могут быть свои статы.Каждый игрок должен иметь особую способность для атаки, которая свойственна
            //     только его классу!
            Random random = new Random();
            int chooseAttack;
            Fighter mag = new Mag("Magusso", random.Next(500,800), random.Next(70,100));
            Fighter warrior = new Warrior("WarrioOOOR", random.Next(1200,1500), random.Next(100,150));

            Console.WriteLine("---------------");
            mag.ShowStats();
            warrior.ShowStats();
            Console.WriteLine("---------------");
            
            while (mag.Health >  0 && warrior.Health > 0)
            {
                Console.WriteLine("\n....Подготовка к атакам....\n");
                chooseAttack = random.Next(1, 3);
                Thread.Sleep(1500);
                if (chooseAttack == 1)
                {
                    mag.TakeDamage(warrior.Damage);
                    warrior.TakeDamage(mag.Damage); 
                }
                else
                {
                    Console.WriteLine("Противники готовят уникальные способности:");
                    mag.TakeDamage(warrior.UniqueAbility());
                    warrior.TakeDamage(mag.UniqueAbility());   
                }
            }

            if (mag.Health == 0 && warrior.Health == 0)
            {
                Console.WriteLine($"\n{mag.Name} и {warrior.Name} погибли");
            }
            else if (mag.Health == 0)
            {
                Console.WriteLine($"\n{mag.Name} погиб");  
            }
            else if (warrior.Health == 0)
            {
                Console.WriteLine($"\n{warrior.Name} погиб");
            }
        }
    }
}