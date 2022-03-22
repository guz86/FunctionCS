namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            // КАНЗАС СИТИ ШАФТ
            //Реализуйте функцию Shuffle, которая перемешивает элементы массива в случайном порядке.

            int[] myArray = {1,2,3,4,5,6,7,8,9,0};
            Shuffle(myArray);
            ShowArray(myArray);
        }
        
        // ver1
        static void Shuffle(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int position = rand.Next(1, 10);
                int tempValue = array[position];
                 array[position] = array[i];
                 array[i] = tempValue;
            }
        }

        static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
}

