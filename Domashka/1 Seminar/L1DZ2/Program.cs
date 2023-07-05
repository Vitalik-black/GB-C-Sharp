// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine ("Введите значение числа a, b");
int number1 = int.Parse(Console.ReadLine()!); // Ввод А
int number2 = int.Parse(Console.ReadLine()!); // Ввод В

if (number1 > number2)
{
Console.WriteLine (number1 + " - Является большим числом из двух введеных");
Console.WriteLine (number2 + " -  Является меньшим числом из двух введеных");
}
 else if (number1 < number2)
{
Console.WriteLine (number2 + " -  Является большим числом из двух введеных");
Console.WriteLine (number1 + " -  Является меньшим числом из двух введеных");
}

else if (number1 == number2)
{
Console.WriteLine (number2 + " -  Введённые числа являються равными между собой ");
}
