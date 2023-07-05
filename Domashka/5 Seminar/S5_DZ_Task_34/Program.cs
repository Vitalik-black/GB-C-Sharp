/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
   [345, 897, 568, 234] -> 2 */

Console.Clear ();

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

int[] CreateRandomMassive(int val)
{
    int [] array = new int [val];
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(0, 999);  // генератор рандомного массива
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


void PrintMath(int[] array)
{
    int num = 0;
    
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            num++;
        }
    }
    Console.Write($" {num} <- количество четных чисел в массиве  ");
}

int value = Prompt("Введите длинну массива: ");

int[] array = CreateRandomMassive (value);
PrintMassive (array);

PrintMath (array);

