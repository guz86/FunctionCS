namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Массивы
            // Наибольший элемент
            // Найти наибольший элемент матрицы A(10,10) и записать ноль в ту ячейку,
            // где он находится. Вывести наибольший элемент, исходную и полученную матрицу.
            //     Массив под измененную версию не нужен.

            int[,] myArray =
            {
                {3, 33, 425, 223, 543, 223, 123, 123, 421, 1234}, {3, 33, 425, 223, 543, 223, 123, 123, 421, 1234},
                {3, 33, 425, 223, 543, 223, 123, 123, 421, 1234}, {3, 33, 425, 223, 543, 223, 123, 123, 421, 1234},
                {3, 33, 425, 223, 543, 223, 123, 123, 421, 1234}, {3, 33, 425, 223, 543, 223, 123, 123, 421, 1234},
                {3, 33, 425, 223, 543, 223, 123, 123, 421, 1234}, {3, 33, 425, 223, 543, 223, 123, 123, 421, 1234},
                {3, 33, 425, 223, 543, 25523, 123, 123, 421, 1234},
                {3, 33, 425, 223, 543, 223, 123, 123, 421, 1234},
            };
            int maxElement = int.MinValue;
            int i = 0, jdMaxElement = 0, kdMaxElement = 0;

            for (int j = 0; j < myArray.GetLength(0); j++)
            {
                for (int k = 0; k < myArray.GetLength(1); k++)
                {
                    if (maxElement < myArray[j, k])
                    {
                        maxElement = myArray[j, k];
                        jdMaxElement = j;
                        kdMaxElement = k;
                    }

                    Console.Write(myArray[j, k] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Max Element " + myArray[jdMaxElement, kdMaxElement]);
            myArray[jdMaxElement, kdMaxElement] = 0;

            for (int j = 0; j < myArray.GetLength(0); j++)
            {
                for (int k = 0; k < myArray.GetLength(1); k++)
                {
                    Console.Write(myArray[j, k] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}