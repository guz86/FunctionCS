namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Массивы
            //     Работа с конкретными строками\столбцами
            //     Дан двумерный массив.
            //     Вычислить сумму второй строки и произведение первого столбца.
            //      Вывести исходную матрицу и результаты вычислений.
            int[,] myArray =
            {
                {1, 2, 3}, 
                {3, 2, 2},
                {2, 9, 3}
            };
            int sumSecondStringArray = 0;
            int multiplyFirstСolumnArray = 1;
            for (int i = 0; i < myArray.GetLength(1); i++)
            {
                sumSecondStringArray += myArray[1, i];
            }
            
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                
                multiplyFirstСolumnArray *= myArray[i, 0];
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j]+" ");
                }

                Console.WriteLine();
            }
            
            Console.WriteLine($"sumSecondStringArray = {sumSecondStringArray}");
            Console.WriteLine($"multiplyFirstСolumnArray = {multiplyFirstСolumnArray}");
            
        }
    }
}