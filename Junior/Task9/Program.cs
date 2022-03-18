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
                {2, 3, 3}
            };
            int sumTwoStringArray = 0;
            int multiplyOneStringArray = 1;
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                sumTwoStringArray += myArray[1, j];
            }
            
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                
                multiplyOneStringArray *= myArray[0, j];
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j]+" ");
                }

                Console.WriteLine();
            }
            
            Console.WriteLine($"sumTwoStringArray = {sumTwoStringArray}");
            Console.WriteLine($"multiplyOneStringArray = {multiplyOneStringArray}");
        }
    }
}