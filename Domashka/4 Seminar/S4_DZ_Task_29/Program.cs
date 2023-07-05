/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.Clear();

int [] Massive(int arg1)
{
    int [] array = new int [arg1];
    for (int i=0; i<array.Length; i++)
    {
        int temp = i+1;  
        array[i] = Prompt ($"Введите номер {temp} элемента " );
    }
        return array;
}

void PrintMassive(int [] arg)
{
        for (int i=0; i<arg.Length; i++)
    {
        Console.Write(arg[i]+", ");
    }
}
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
int value = Prompt ("Введите колличество элементов для создания массива "); // длину массива
int [] array = Massive (value);
PrintMassive (array);