﻿/*Напишите программу которая на вход принимает два числа и проверят, является ли первое число квадратом второго.

a = 25 b = 5 -> да 
a = 2 b = 10 -> нет
a = 9 b -3 -> да
a = -3 b = 9 -> нет

*/
Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine("является");
}
else
{
    Console.WriteLine("не является");
}
