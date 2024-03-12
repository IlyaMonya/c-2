/* Напишите программу которая принимает на вход трезначное число и на выходе показывает последнюю цифру этого числа
*/

Console.WriteLine("напишите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>99 && number <1000)
{
    Console.WriteLine(number%10);
}
else
{
    Console.WriteLine("число не трехзначное");
}

