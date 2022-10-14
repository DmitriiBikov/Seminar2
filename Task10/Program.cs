// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 100 || number > 1000)
{
   Console.WriteLine($"Вы ввели не трехзначное число =(");
   number = Convert.ToInt32(Console.ReadLine());
}
int number_2 = number / 10 % 10;
Console.WriteLine($"Вторая цифра этого числа: {number_2}");
