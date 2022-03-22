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
            
            // ver1
            bool exit = true;
            string input;
            while (exit)
            {
                Dictionary<string, string> myDictionary = new Dictionary<string,string>();
                myDictionary.Add("бабенка","Молодая бойкая женщина");
                myDictionary.Add("багаж","Вещи, груз пассажиров, упакованные для отправки, перевозки");
                myDictionary.Add("багор","Шест с металлическим крюком и остриём");
                myDictionary.Add("базис","В материалистическом социологическом учении: совокупность");

                Console.WriteLine("Введите слово(бабенка, багаж, багор, базис):");
                input = Console.ReadLine();
                bool keyCheck = false;
                
                if (!String.IsNullOrEmpty(input))
                {
                    keyCheck = myDictionary.ContainsKey(input);
                }
                
                if (keyCheck)
                {
                    Console.WriteLine(myDictionary[input]);
                }
                
                if (input == "exit")
                {
                    exit = false;
                }

                Console.ReadKey();
                Console.Clear();

            }
        }

    }
}