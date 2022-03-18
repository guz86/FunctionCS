using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Бой с боссом
            // Легенда: Вы – теневой маг(можете быть вообще хоть кем) и у вас в арсенале есть несколько заклинаний,
            // которые вы можете использовать против Босса.Вы должны уничтожить босса и только после этого будет вам покой.
            // Формально: перед вами босс, у которого есть определенное кол - во жизней и определенный ответный урон.
            // У вас есть 4 заклинания для нанесения урона боссу.Программа завершается только после смерти босса или смерти пользователя.
            // Пример заклинаний
            // Рашамон – призывает теневого духа для нанесения атаки(Отнимает 100 хп игроку)
            // Хуганзакура(Может быть выполнен только после призыва теневого духа), наносит 100 ед.урона
            // Межпространственный разлом – позволяет скрыться в разломе и восстановить 250 хп.Урон босса по вам не проходит
            // Заклинания должны иметь схожий характер и быть достаточно сложными, они должны иметь какие-то условия выполнения(пример -Хуганзакура).
            // Босс должен иметь возможность убить пользователя.

            // BossFighter_v1
            
            Random rand = new Random();

            int bossHealth = rand.Next(1500, 2000);
            int bossDamage = rand.Next(300, 500);
            int playerHealth = rand.Next(450, 850);

            int spell;
            int spellOne = rand.Next(50, 100);
            bool spirit = false;
            int spellTwo = rand.Next(300, 800);
            int spellThree = rand.Next(50, 100);
            int spellFour = rand.Next(100, 120);
            int spellFourEnd = rand.Next(15, 90);
            bool sucksSpellFour = false;
            int spellFive = 1;
            bool attackspellFive = false;
            bool flagSpellThree = false;

            int attackbossDamage;
            int attackSpellThree;
            int iFour = 0;
            int iFive = 0;

            Console.WriteLine("Вы вышли на бой с Боссом!");
            Console.WriteLine("Health Boss: " + bossHealth + ", Damage: " + bossDamage + " | Your Health: " + playerHealth);
            // Console.WriteLine("Сила заклинаний: \nРашамон " + spellOne + ", \nХуганзакура "
            //   + spellTwo + ", \nРазлом " + spellThree + ", \nАвертула " + spellFour + "-" + spellFourEnd + ", " + "\nКарабанжа " + spellFive);

            while (bossHealth > 0 && playerHealth > 0)
            {
                Console.WriteLine("\n* * * * * * * * * ");
                Console.Write(" >> Выбери номер заклинания - Рашамон(1), Хуганзакура(2), Разлом(3), Авертула(4), Карабаранжа(5): ");
                spell = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("* * * * * * * * * \n");
                Thread.Sleep(1500);
                switch (spell)
                {
                    // Рашамон - призывает теневого духа для нанесения атаки -50хп игроку
                    case 1:
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("Рамашон...");
                            Thread.Sleep(700);
                        }
                        Console.WriteLine("Вызывается теневой дух, который может нанести сильный урон, " + spellOne + " HP отнимается у Вас!");

                        playerHealth -= spellOne;
                        spirit = true;
                        flagSpellThree = false;
                        break;
                    // Хугунзакура - 100 урона от теневого духа, только если теневой дух вызван.
                    case 2:
                        if (spirit)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                Console.WriteLine("Хугунзакура...");
                                Thread.Sleep(700);
                            }
                            bossHealth -= spellTwo;
                            Console.WriteLine("Теневой дух наносит сильный урон в " + spellTwo + " HP!");
                            spirit = false;
                        }
                        else
                        {
                            Console.WriteLine("Дух не вызван, сначала произнесите Рашамон!");
                        }
                        flagSpellThree = false;
                        break;
                    // Разлом - скрыться и восстановить 250 хп, урона от босса нет, нельзя использовать 2 раза подряд
                    case 3:
                        if (flagSpellThree == false)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                Console.WriteLine("Разлом...");
                                Thread.Sleep(700);
                            }
                            attackSpellThree = rand.Next(50, spellThree);
                            playerHealth += attackSpellThree;
                            Console.WriteLine("Вы скрылись в разломе и восстановили " + attackSpellThree + " HP");
                            // используем спел уклонения
                            spellFive = 0;
                            flagSpellThree = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Нельзя использовать Разлом 2 раза подряд!");
                            break;
                        }
                    // Авертула - высасывать душу из босса, разово снимет 60хп и пополнит их герою дополнительно будет отниматься следующие 2 атаки по 30 хп. Можно выполнить если нет теневого духа.
                    case 4:
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("Авертула...");
                            Thread.Sleep(700);
                        }
                        Console.WriteLine("Вы высасываете душу у босса, он потерял и вы восстановили " + spellFour + " HP!");
                        Thread.Sleep(1500);
                        Console.WriteLine("На босса наложено заклятие!");
                        bossHealth -= spellFour;
                        playerHealth += spellFour;
                        sucksSpellFour = true;
                        flagSpellThree = false;
                        break;


                    // Карабаранжа - отразить удар босса, хп не снимется, но следующая атака босса будет на 50% ниже по урону. выполняется если босс не под проклятием. 
                    case 5:

                        if (sucksSpellFour == false)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                Console.WriteLine("Карабаранжа...");
                                Thread.Sleep(700);
                            }
                            Console.WriteLine("Вы отражаете удар Босса, его мораль понижена, следующая атака в 2 раза ниже.");
                            spellFive = 0;
                            attackspellFive = true;
                        }
                        else
                        {
                            Console.WriteLine("Босс под проклятием, нельзя использовать заклинание Карабанжа!");
                        }
                        flagSpellThree = false;
                        break;
                    default:
                        Console.WriteLine("Вы не знаете это заклинание");
                        break;

                }

                if (sucksSpellFour)
                {

                    if (iFour >= 1)
                    {
                        bossHealth -= spellFourEnd;

                        playerHealth += spellFour;
                        Console.WriteLine("При высасывании души босс дополнительно теряет, а Вы получаете " + spellFourEnd + " HP");
                    }
                    iFour += 1;

                    if (iFour == 3)
                    {
                        sucksSpellFour = false;
                        Console.WriteLine("Заклятие с босса снято!");
                        iFour = 0;
                    }



                }


                // Boss attack
                attackbossDamage = rand.Next(90, bossDamage) * spellFive;
                // attackspellFive
                if (attackspellFive)

                {
                    if (iFive == 1)
                    {
                        attackbossDamage = attackbossDamage / 2;
                        Console.WriteLine("Урон босса уменьшен в 2 раза!");

                    }
                    iFive += 1;
                    if (iFive == 2)
                    {
                        attackspellFive = false;
                        iFive = 0;
                    }
                }


                // spellFive обнуляем действие 5 спела
                spellFive = 1;

                Thread.Sleep(1500);
                Console.WriteLine("Босс наносит удар: " + attackbossDamage);
                playerHealth -= attackbossDamage;

                Thread.Sleep(1500);
                Console.WriteLine("\nHealth Boss: " + bossHealth + " | Your Health: " + playerHealth + "\n");

            }
            Thread.Sleep(1500);
            if (bossHealth <= 0 && playerHealth <= 0)
            {
                Console.WriteLine("Оба мертвы");
                Console.ReadKey();
            }
            else if (bossHealth <= 0)
            {
                Console.WriteLine("Вы победили Босса!");
                Console.ReadKey();
            }
            else if (playerHealth <= 0)
            {
                Console.WriteLine("Вы проиграли!");
                Console.ReadKey();
            }





        }

    }
}
