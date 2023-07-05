/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Clear ();
int Prompt (string msg) // Проверка на ввод числа или других стмволов
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    { Console.WriteLine("Вы ввели не число, повторите ввод ");     }
    return val;
}
void Sum (int value)
{
int digit1 = value / 10000;
int digit2 = (value / 1000)%10;
int digit3 = (value / 100)%10;
int digit4 = (value / 10)%10;
int digit5 = value %10;
int sum = digit1 + digit2 + digit3 + digit4 + digit5;
Console.WriteLine ("Сумма цифр в чиселе --> "+ sum);
}

int value = Prompt ("Введите число, не длинее 5 сиволов: ");
Sum (value);
