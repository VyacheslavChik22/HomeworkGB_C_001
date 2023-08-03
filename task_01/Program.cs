/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите первое число: ");

string? firstString = Console.ReadLine();
double firstNumber = Convert.ToDouble(firstString);

Console.Write("Введите второе число: ");

string? seckondString = Console.ReadLine();
double seckondNumber = Convert.ToDouble(seckondString);

if(firstNumber > seckondNumber )
{
    Console.WriteLine($"Первое число: {firstNumber} больше чем второе: {seckondNumber}");
}else
{
Console.WriteLine($"Второе число: {seckondNumber} больше чем первое: {firstNumber}");
}
