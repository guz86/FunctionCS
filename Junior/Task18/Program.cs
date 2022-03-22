namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Коллекции
            //     Толковый словарь
            // Создать программу, которая принимает от пользователя слово и выводит его значение.
            // Если такого слова нет, то следует вывести соответствующее сообщение.

            // ver2
            string input;
            while (true)
            {
                Dictionary<string, string> myDictionary = new Dictionary<string, string>();
                myDictionary.Add("бабенка", "Молодая бойкая женщина");
                myDictionary.Add("багаж", "Вещи, груз пассажиров, упакованные для отправки, перевозки");
                myDictionary.Add("багор", "Шест с металлическим крюком и остриём");
                myDictionary.Add("базис", "В материалистическом социологическом учении: совокупность");

                Console.Write("Введите слово(бабенка, багаж, багор, базис): ");
                input = Console.ReadLine();

                bool keyCheck = false;

                //if (!String.IsNullOrEmpty(input))
                if (input != null)
                {
                    keyCheck = myDictionary.ContainsKey(input);
                }

                if (input == "exit")
                {
                    break;
                }

                if (keyCheck)
                {
                    Console.WriteLine($"\"{input}\" - {myDictionary[input]}");
                }
                else
                {
                    Console.WriteLine($"\"{input}\" -  нет в словаре");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}