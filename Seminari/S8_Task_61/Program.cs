﻿Console.Clear();

Console.Write("Введите нужное количество строк треугольника Паскаля: ");
int rows = int.Parse(Console.ReadLine());
PrintTriangle(rows);


void PrintTriangle(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int c = 0; c <= (n - i); c++) // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
        {
            Console.Write("  ");
        }
        for (int c = 0; c <= i; c++)
        {
            Console.Write("   "); // создаём пробелы между элементами треугольника
            Console.Write(factorial(i) / (factorial(c) * factorial(i - c))); //формула вычисления элементов треугольника
        }
        Console.WriteLine(); // после каждой строки с числами отступаем две пустые строчки
    }
}
float factorial(int n)
{
    float x = 1;
    for (int i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}