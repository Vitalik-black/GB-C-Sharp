/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void PrintArray(double[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "-");
    }
    Console.Write(array[array.Length - 1] + " ");
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0 ; i < matrix.GetLength(0) ; i ++)
    {
        for (int j = 0 ; j<matrix.GetLength(1) ; j ++)
        {
            Console.Write($" {matrix [i , j]}");
        }
    Console.WriteLine();
    }
}

int[,] CreateRandoMassive (int rows , int colums , int minValue, int maxValue)
{
    int [,] matrix = new int[rows,colums];
    maxValue ++;
    for (int i = 0 ; i < matrix.GetLength(0) ; i ++)
    {
        for (int j = 0 ; j<matrix.GetLength(1) ; j ++)
        {
            matrix[i,j] = new Random().Next(minValue,maxValue);
        }
    }
    return matrix;
}

int rows = Prompt("Ведите количество строк массива: ");
int colums = Prompt("Введите количество столбцов массива: ");
int minValue = Prompt("Введите начально значение элементов массива: ");
int maxValue = Prompt("Введите конечное значение элементов массива: ");

int[,] matr = CreateRandoMassive(rows,colums,minValue,maxValue);
double[] summColums = new double [matr.GetLength(1)];

PrintMatrix(matr);
Console.WriteLine();


for (int j = 0 ; j < matr.GetLength(1) ; j ++)
{
    int summ = 0;
    for (int i = 0 ; i < matr.GetLength(0) ; i ++)
    {
        summ = summ + matr[i,j];
    }

    summColums[j] = summ;
    Console.Write($"{summColums} ");
    Console.WriteLine();
}

PrintArray(summColums);
Console.WriteLine();
for (int i = 0;i<summColums.Length;i++)
{
    Console.WriteLine($"Среднее арифметическое значение {i+1} столбца равно {summColums[i]/matr.GetLength(1)}");
}
