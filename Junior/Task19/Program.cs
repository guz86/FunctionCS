namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Очередь в магазине
            //     У вас есть множество целых чисел. Каждое целое число - это сумма покупки.
            //     Вам нужно обслуживать клиентов до тех пор, пока очередь не станет пуста.
            //     После каждого обслуженного клиента деньги нужно добавлять на наш счёт и выводить его в консоль.
            //     После обслуживания каждого клиента программа ожидает нажатия любой клавиши, после чего затирает
            // консоль и по новой выводит всю информацию, только уже со следующим клиентом

            //ver1
            var myQueue = AddQueue(15);
            int money = 0;
            int i = 1;

            while (myQueue.Count > 0)
            {
                money += myQueue.Dequeue();
                Console.WriteLine($"Обслужили клиента номер {i}, " + $"осталось в очереди {myQueue.Count} человек" +
                                  $"\n На счету оказалось {money}");
                Console.ReadLine();
                Console.Clear();
                i++;
            }

            Console.WriteLine($"Всего заработано: {money}");
        }

        static Queue<int> AddQueue(int count)
        {
            Random rand = new Random();
            Queue<int> queue = new Queue<int>();

            while (queue.Count < count)
            {
                int value = rand.Next(100, 1000);
                queue.Enqueue(value);
            }

            return queue;
        }
    }
}