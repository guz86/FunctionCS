namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Динамический массив
            // Пользователь вводит числа, и программа их запоминает.
            //     Как только пользователь введёт команду sum, программа выведет сумму всех веденных чисел.
            //     Выход из программы должен происходить только в том случае, если пользователь введет команду exit.
            //     Программа должна работать на основе расширения массива.
            //     Внимание, нельзя использовать List<T> и Array.Resize
            // ver1
            bool exit = true;
            string input;
            int i = 0;
            int sum = 0;
            int[] myArray = new int[1];

            while (exit)
            {
                
                input = Console.ReadLine();
                if (input == "exit") exit = false;

                if (input == "sum")
                {
                    foreach (var element in myArray)
                    {
                        sum += element;
                    }

                    Console.WriteLine(sum);
                    sum = 0;
                }

                if (int.TryParse(input, out int number))
                {
                    int[] myArrayTemp = new int[i + 1];
                    for (int j = 0; j < myArray.Length; j++)
                    {
                        myArrayTemp[j] = myArray[j];
                    }

                    myArrayTemp[^1] = number;
                    myArray = myArrayTemp;
                }
            
                i++;
                
            }
        }
    }
}