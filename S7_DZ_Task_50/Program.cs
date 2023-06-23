/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого числа в массиве нет [1,7]-это позиция элемента 1 - строка, 7 - столбец */

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}

int[,] CreateRandoArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];
    maxValue++;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PozitionsArray(int[,] array, int arg1, int arg2)
{
    if (arg1 >= array.GetLength(0) || arg2 >= array.GetLength(1))
    {
        Console.WriteLine($"Элемента стоящего на позиции [{arg1}, {arg2}] нет!");
    }
    else
    {
        Console.WriteLine($"Элемент стоящий на позиции [{arg1}, {arg2}] равен: {array[arg1, arg2]}");
    }
}

int row = Prompt("Ведите количество строк массива: ");
int col = Prompt("Введите количество столбцов массива: ");
int minValue = Prompt("Введите начальное значение элементов массива: ");
int maxValue = Prompt("Введите конечное значение элементов массива: ");
int[,] array = CreateRandoArray(row, col, minValue, maxValue);
PrintArray(array);
int line = Prompt("Ведите номер строки массива: ");
int column = Prompt("Введите номер столбца массива: ");
PozitionsArray(array, line, column);