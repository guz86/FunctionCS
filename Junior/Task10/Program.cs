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
            
                // это если один максимальный элемент в матрице
                // если их несколько то без привязки к j,k по занчению maxElement

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
            
            
            
            // чтоб массив выводил с одной увеличинной  буквой вот к приму чтоб так   "sUn", "rOn", "tUe"
            
            string[] array = { "sun", "ron", "tue" };
            for (int j = 0; j < array.Length; j++)
            {
                for (int k = 0; k < array[i].Length; k++)
                {
                    if (k == 1)
                    {
                        Console.Write(array[j][k].ToString().ToUpper());
                    }
                    else
                    {
                        Console.Write(array[j][k]);
                    }
                }
                Console.WriteLine();
            }
            
        
        
        
        
        
        }
    }
}