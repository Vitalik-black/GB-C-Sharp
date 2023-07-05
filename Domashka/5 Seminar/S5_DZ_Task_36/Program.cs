/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Clear ();

int Prompt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    {
    Console.WriteLine("Это не число ");
    }
    return val;
}

int[] CreateMassive(int size, int minValue, int maxValue)
{
    int [] array = new int [size];
    for (int i=0; i<size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);  // генератор рандомного массива
    }
    return array;
}

void PrintMassive(int[] array)
{
    Console.Write ("[");
    for (int i=0; i<array.Length; i++)
    {
    Console.Write (array[i]+" ");
    }
    Console.Write ("] ");
}

void SumPozitions (int[] array)
{
    int result = 0;
    for (int i=0; i < array.Length; i++)
    {
       if (i%2 !=0) result += array [i];
    }
    Console.Write($" {result} <- сумму элементов, стоящих на нечётных позициях.  ");
}




int size = Prompt("Введите длинну массива: ");
int minValue =Prompt("Введите начальное трехзначное значение для дипазона случайных чисел: ");
int maxValue =Prompt("Введите конечное трехзначное значение для дипазона случайных чисел: ");
int[] array = CreateMassive (size, minValue, maxValue);

PrintMassive (array);
Console.WriteLine("");
SumPozitions (array);

