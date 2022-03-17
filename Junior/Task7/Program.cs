namespace Task7;

class Program
{
    public static void Main(string[] arg)
    {
        // Программа под паролем
            // Создайте переменную типа string, в которой хранится пароль для доступа к тайному сообщению.
            // Пользователь вводит пароль, далее происходит проверка пароля на правильность,
            // и если пароль неверный, то попросите его ввести пароль ещё раз.
            // Если пароль подошёл, выведите секретное сообщение.
            // Если пользователь неверно ввел пароль 3 раза, программа завершается.

            // PasswordCheck_v1
            
            /*int i = 0;
            string password = "666";
            Console.WriteLine("Доступ закрыт!");
            while (true)
            {
                
                Console.Write("Введите пароль:");
                
                if (password == Console.ReadLine() && i <= 2)
                {
                    Console.WriteLine("Секретное сообщение: И приснился мне, город с незнакомыми людьми, вышли все под дождь...");
                    break;
                }
                else if (i < 2)
                {
                    i += 1;
                }
                else 
                {
                    Console.WriteLine("Количество попыток закончилось.");
                    break;
                }

            }*/
            

            // PasswordCheck_v2
            /*
            string password = "666";
            Console.WriteLine("Доступ закрыт!");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите пароль:");
                // Object.Equals Метод Определяет, равны ли два экземпляра объекта. person1.Equals(person2) 
                if (!password.Equals( Console.ReadLine() ) )
                {
                    Console.WriteLine("Не верный пароль");
                }
                else
                {
                    Console.WriteLine("Секретное сообщение: И приснился мне, город с незнакомыми людьми, вышли все под дождь...");
                    break;
                }
            }
            */
            
            // PasswordCheck_v3
            string password = "666";
            Console.WriteLine("Доступ закрыт!");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите пароль:");

                if (password.Equals(Console.ReadLine())) 
                {
                    Console.WriteLine("Секретное сообщение: И приснился мне, город с " +
                                      "незнакомыми людьми, вышли все под дождь...");
                    break; 
                }
                Console.WriteLine("Не верный пароль");
            }
    }
}