/* Напишите программу которая принимает на вход трезначное число и на выходе показывает последнюю цифру этого числа
*/

Console.WriteLine("напишите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number%10);

