﻿

Console.Clear();

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    return val;
}

void PrintMatrix (int[,] matrix)
{
    for (int row = 0 ; row < matrix.GetLength(0) ; row ++)
    {
        for (int colum = 0 ; colum<matrix.GetLength(1) ; colum ++)
        {
            Console.Write($" {matrix [row , colum]}");
        }
    Console.WriteLine();
    }
}

int[,] CreateMRandoMatrix (int rows , int colums , int from , int to)
{
    int [,] matrix = new int[rows,colums];
    to ++;
    for (int row = 0 ; row < matrix.GetLength(0) ; row ++)
    {
        for (int colum = 0 ; colum<matrix.GetLength(1) ; colum ++)
        {
            matrix[row,colum] = new Random().Next(from,to);
        }
    }
    return matrix;
}

int[,] MultuMatrix(int[,] matrix1, int[,] matrix2, int rows, int colums)
{
    int[,] result = new int [rows,colums];

    for (rows = 0 ; rows < result.GetLength(0) ; rows ++)
    {
        for (colums = 0 ; colums<result.GetLength(1) ; colums ++)
        {
            result[rows,colums]=matrix1[rows,colums]*matrix2[rows,colums];
        }
    }
    return result;
}

int row = Prompt("Ведите количество строк массивов: ");
int col = Prompt("Введите количество столбцов массивов: ");
int from1 = Prompt("Введите начально значение элементов 1 массива: ");
int to1 = Prompt("Введите конечное значение элементов 1 массива: ");
int from2 = Prompt("Введите начально значение элементов 2 массива: ");
int to2 = Prompt("Введите конечное значение элементов 2 массива: ");
int[,] matr1 = CreateMRandoMatrix(row,col,from1,to1);
int[,] matr2 = CreateMRandoMatrix(row,col,from2,to2);
int[,] result = MultuMatrix(matr1, matr2, row, col);
PrintMatrix(matr1);
Console.WriteLine();
PrintMatrix(matr2);
Console.WriteLine();
PrintMatrix(result);