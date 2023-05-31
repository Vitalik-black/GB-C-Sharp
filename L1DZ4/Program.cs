// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine ("Введите значение числа a");
Console.WriteLine ("Введите значение числа b");
Console.WriteLine ("Введите значение числа c");
int number1 = int.Parse(Console.ReadLine()!); // Ввод А
int number2 = int.Parse(Console.ReadLine()!); // Ввод В
int number3 = int.Parse(Console.ReadLine()!); // Ввод C

if (number1 > number2 && number1 > number3)
{
Console.WriteLine (number1 + " - Является Максимальным числом из трёх введеных");
}
 else if (number2 > number1 && number2 > number3)
{
Console.WriteLine (number2 + " - Является Максимальным числом из трёх введеных");
}

 else if (number3 > number1 && number3 > number2)
{
Console.WriteLine (number3 + " - Является Максимальным числом из трёх введеных");
}

/*else if (number1 == number2 && number1 == number3);
{
Console.WriteLine (number1 + " -  Введённые числа являються равными между собой ");
}*/