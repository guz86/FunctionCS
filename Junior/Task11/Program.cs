namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Локальные максимумы
            // Дан одномерный массив целых чисел из 30 элементов.
            // Найдите все локальные максимумы и вывести их. (Элемент является локальным максимумом,
            // если он не имеет соседей, больших, чем он сам)
            // Крайние элементы являются локальными максимумами если не имеют соседа большего, чем они сами.
            // Программа должна работать с массивом любого размера.
            // Массив всех локальных максимумов не нужен.

            // generate myArray
            Random rand = new Random();
            int[] myArray = new int[30];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rand.Next(1, 999);
                Console.Write(myArray[i]+ " ");
            }

            Console.WriteLine();
            // local maximum ver1
            for (int i = 0; i < myArray.Length; i++)
            {
                if (i == 0)
                {
                    if(myArray[i] > myArray[i+1]) Console.Write(myArray[i] + " ");
                    
                }
                else if (i == myArray.Length - 1) 
                {
                    if(myArray[i] > myArray[i-1]) Console.Write(myArray[i] + " ");
                }
                else 
                {
                    if (myArray[i] > myArray[i-1] && myArray[i] > myArray[i+1]) Console.Write(myArray[i] + " ");
                }
            }

            Console.WriteLine();
            // ver2
            if (myArray[0] > myArray[1]) Console.Write(myArray[0] + " ");
            for (int i = 1; i < myArray.Length - 1; i++)
            {
                if (myArray[i] > myArray[i-1] && myArray[i] > myArray[i+1]) Console.Write(myArray[i] + " ");
            }
            if (myArray[^1] > myArray[^2]) 
                Console.Write(myArray[^1] + " ");
            
            
        }

    }
}




