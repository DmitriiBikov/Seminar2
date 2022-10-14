// Задача 13:
//  Напишите программу, которая выводит третью цифру заданного числа 
//  или сообщает, что третьей цифры нет. 
//  Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
// int number_2 = Convert.ToInt32(Console.ReadLine());





// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// {
//     while (number < 99)
//    Console.WriteLine($"Третьей цифры в заданном вами числе нет =(");
//    number = Convert.ToInt32(Console.ReadLine());
// }
// {
// number = Convert.ToInt32(Console.ReadLine());

//     while (number > 999);
    
//     int number_2 = number / 10;
    
//     number = Convert.ToInt32(Console.ReadLine());
// }
//     {
// while (number < 999 || number > 99);
// int number = number % 10;
//     }
// Console.WriteLine($"Третья цифра этого числа: {number}");

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
 
if (number < 100)
   Console.WriteLine($"Третьей цифры в заданном вами числе нет =(");
else 
{
    while (number > 999)
    {
        number = number / 10;
    }
    int number_3 = number % 10;
Console.WriteLine($"Третья цифра этого числа: {number_3}");
}