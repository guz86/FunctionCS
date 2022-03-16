// See https://aka.ms/new-console-template for more information

// Условные операторы и циклы
// Освоение циклов
// При помощи циклов вы можете повторять один и тот же код множество раз.
//     Напишите простейшую программу, которая выводит указанное(установленное)
// пользователем сообщение заданное количество раз.

Console.WriteLine("Введите сообщение");
string Message = Console.ReadLine();
Console.WriteLine("Введите сколько раз его нужно вывести");
int.TryParse(Console.ReadLine(),out int count);
while (count > 0)
{
    Console.WriteLine(Message);
    count--;
}