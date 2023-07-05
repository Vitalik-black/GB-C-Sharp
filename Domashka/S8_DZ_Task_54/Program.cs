/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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

int[,] CreateRandoMassive(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }
    return array;
}

int[,] OrderingMassive(int[,] array)
{
    int[,] result = array;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int max = array[i, 0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int maxPosition = j;
            for (int n = j + 1; n < array.GetLength(1); n++)
            {
                if (array[i, n] > array[i, maxPosition]) maxPosition = n;
            }
            int temparr = result[i, j];
            result[i, j] = result[i, maxPosition];
            result[i, maxPosition] = temparr;
        }
    }

    return result;
}

int rows = Prompt("Ведите количество строк массива: ");
int colums = Prompt("Введите количество столбцов массива: ");
// int minValue = Prompt("Введите начально значение элементов массива: ");
// int maxValue = Prompt("Введите конечное значение элементов массива: ");

int[,] matr = CreateRandoMassive(rows, colums);
int[,] array = OrderingMassive(matr);

PrintArray(array);
Console.WriteLine();


