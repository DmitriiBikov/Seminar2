// Задача 15: 
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и 
// проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


// while (number < 1 || number > 7)
// {
//     Console.WriteLine($"Такого дня недели не существует =(");
//     number = Convert.ToInt32(Console.ReadLine());
// }
// {
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
 case1:
Console.WriteLine("Понедельник");
brake;
case2:
Console.WriteLine("Вторник");
brake;
case3:
Console.WriteLine("Среда");
brake;
case4:
Console.WriteLine("Четверг";)
brake;
case5:
Console.WriteLine("Пятница");
brake;
case6:
Console.WriteLine("Суббота - Выходной");
brake;
case7:
Console.WriteLine("Воскресенье - выходной");
brake;
default:
Console.WriteLine("Нет такого дня недели");
brake;
}