// Задача №1 Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго?
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 10 -> нет

Console.WriteLine ("Введите значение числа a, b");
int number1 = int.Parse(Console.ReadLine()); // Ввод А
int number2 = int.Parse(Console.ReadLine()); // Ввод В
int result = number2*number2;
if (result == number1)
{
Console.WriteLine ("ДА - является квадратом");
}
else
{
Console.WriteLine ("Нет - Не является квадратом");
}
