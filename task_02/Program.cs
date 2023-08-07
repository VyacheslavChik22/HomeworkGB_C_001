/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
   2, 3, 7 -> 7
   44 5 78 -> 78
   22 3 9 -> 22
 */

Console.Write("Введите первое число: ");

string? firstString = Console.ReadLine();
double firstNumber = Convert.ToDouble(firstString);

Console.Write("Спасибо, теперь введите второе число: ");

string? seckondString = Console.ReadLine();
double seckondNumber = Convert.ToDouble(seckondString);

Console.Write("Спасибо, ну и ещё введите третье число: ");

string? thirdString = Console.ReadLine();
double thirdNumber = Convert.ToDouble(thirdString);

Console.Write("Так, теперь подумаю какое из этих чисел большее...м.м.м.м..м.. ");


double max = firstNumber;
if (seckondNumber > max) max = seckondNumber;
if (thirdNumber > max) max = thirdNumber;

Console.Write($"Ну вот, число  {max} самое большое!");
