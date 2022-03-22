namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            // Динамический массив продвинутый
            //     В массивах вы выполняли задание "Динамический массив"
            // Используя всё изученное, напишите улучшенную версию динамического массива
            // (не обязательно брать своё старое решение)
            // Задание нужно, чтобы вы освоились с List и прощупали его преимущество.
            //     Проверка на ввод числа обязательна.
            //     Пользователь вводит числа, и программа их запоминает.
            //     Как только пользователь введёт команду sum, программа выведет сумму всех веденных чисел.
            //     Выход из программы должен происходить только в том случае, если пользователь введет команду exit.

            //ver1
            List<int> myList = new List<int>();
            string input;
            int sum = 0;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "exit") return;

                if (input == "sum")
                {
                    foreach (var element in myList)
                    {
                        sum += element;
                    }

                    Console.WriteLine($"sum = {sum}");
                    // clear
                    myList.Clear();
                    sum = 0;
                }

                if (int.TryParse(input, out int number))
                {
                    myList.Add(number);
                }
            }
        }
    }
}