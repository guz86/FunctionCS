namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            // генерация числа с уникальными цифрами
            Random rnd = new Random();

            //ver1
            int arraySize = 4; // от 1 до 9
            int[] myNumber = new int[arraySize];
            bool NumReapeat;
            int numberTemp;

            for (int i = 0; i < arraySize;)
            {
                numberTemp = rnd.Next(0, 10);
                NumReapeat = false;

                for (int j = 0; j < i; j++)
                {
                    if (myNumber[j] == numberTemp)
                    {
                        NumReapeat = true;
                        break;
                    }
                }

                if (!NumReapeat)
                {
                    myNumber[i] = numberTemp;
                    i++;
                }
            }

            Console.WriteLine(Convert.ToInt32(string.Join("", myNumber)));

            // чей то код

            var digits = Enumerable.Range(0, 10).ToList();
            int result = 0;

            for (int i = 0, power10 = 1000; i < 4; i++, power10 /= 10)
            {
                int digit = digits[rnd.Next(i == 0 ? 1 : 0, digits.Count)];

                result += digit * power10;
                digits.Remove(digit);
            }

            Console.WriteLine(result);

            // версия с телеги
            int size = 4;
            HashSet<int> setOfNumbers = new HashSet<int>(size);

            while (setOfNumbers.Count < size)
            {
                setOfNumbers.Add(rnd.Next(0, 10));
            }

            // мой вывод
            string myNumber1 = "";
            foreach (var number in setOfNumbers)
            {
                myNumber1 += number;
            }

            Console.WriteLine(myNumber1);
        }
    }
}