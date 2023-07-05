Console.Clear();

int number = Prompt("Введите число: ");
Console.WriteLine(PrintNumber(number));

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

string PrintNumber(int number)
{
    if (number == 1) return "1";

    return $"{PrintNumber(number - 1)} {number}";
}