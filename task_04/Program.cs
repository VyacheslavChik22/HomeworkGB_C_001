/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите целое число!");
int introduce = int.Parse(Console.ReadLine()!);
int number = 1;


if (introduce % 2 != 0)
{
    while (number != introduce + 1)
    {
        if (number % 2 == 0) Console.Write($"{number}");
        if (number % 2 == 0 && number != introduce - 1) Console.Write(", ");

        number++;
    }
}
else
{
while (number != introduce + 1)
    {
        if (number % 2 == 0) Console.Write($"{number}");
        if (number % 2 == 0 && number != introduce) Console.Write(", ");

        number++;
    }
}