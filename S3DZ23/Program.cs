/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear();

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Вы ввели не число, повторите ввод ");
    }
        Console.WriteLine("Вывод чисел от 1 до заданного числа N");
    return val;
}

void Cub (int val)
{
    for (int count = 1; count <= Math.Abs(val); count++)
    {
        Console.Write(Math.Pow(count, 3) + ", ");
    }  
}
int txt = Prompt("Введите число: ");
Cub(txt);