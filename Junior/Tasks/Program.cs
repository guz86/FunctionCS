// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

//namespace Tasks
//{
 //  class Program
//   {
//      static void Main(string[] args){
      
         int a = 10;
         int b = 38 * 17; //646
         int c = (31 - 5 * a) / b; //  выражение = 0.02
         Console.WriteLine(c); // 0 


         // Картинки
         // На экране, в специальной зоне, выводятся картинки, по 3 в ряд. Всего у пользователя в альбоме 52 картинки.
         // Код должен вывести, сколько полностью заполненных рядов можно будет вывести, и сколько картинок будет
         //     сверх меры.
         // В качестве решения ожидаются объявленные переменные с необходимыми значениями и, основываясь 
         // на значениях переменных, вывод необходимых данных.
         int maxImage = 52;
         int countImage = 3;
         int row = maxImage / 3;
         int lagImage = maxImage % 3;
         Console.WriteLine($"raw: {row}");
         Console.WriteLine($"lagImage: {lagImage}");
        
         //  Магазин
         // Легенда:
         // Вы приходите в магазин и хотите купить за своё золото кристаллы.
         // В вашем кошельке есть какое-то количество золота, продавец спрашивает у вас,
         // сколько кристаллов вы хотите купить? После сделки у вас остаётся какое-то количество золота
         // и появляется какое-то количество кристаллов.
         //
         // Формально:
         // При старте программы пользователь вводит начальное количество золота.
         // Потом ему предлагается купить какое-то количество кристаллов по цене N(задать в программе самому).
         // Пользователь вводит число и его золото конвертируется в кристаллы.
         // Остаток золота и кристаллов выводится на экран.
         // Проверять на то, что у игрока достаточно денег ненужно.
         int costCristall = 5;
         Console.WriteLine("Цена за кристалл составляет 5 монет");

         Console.Write("Введите сколько у вас золота: ");
         int.TryParse(Console.ReadLine(), out int gold);
         
         Console.WriteLine();
         Console.WriteLine("Сколько кристалов вы хотите приобрести: ");
         int.TryParse(Console.ReadLine(), out int crystal);
         gold -= crystal * costCristall;

         Console.WriteLine($"У вас {gold} монет и {crystal} кристаллов");


//     } 
//   }

//}

