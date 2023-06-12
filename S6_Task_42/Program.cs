// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int num = Reader();
switch (num)
{
    case -1:
        Console.WriteLine("invalid number format");
        break;
    default:
        int count = CountDifiner(num);
        PrintBinary(BinaryNumConverter(num, count));
        break;
}
int Reader()
{
    Console.WriteLine("enter your number: ");
    if (int.TryParse(Console.ReadLine(), out int num) == false || num < 0)
    {
        num = -1;
        return num;
    }
    else
    {
        return num;
    }
}

int CountDifiner(int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num / 2;
        count++;
    }
    return count;
}

int[] BinaryNumConverter(int num, int count)
{
    int[] binaryNum = new int[count];
    for (int i = count - 1; i >= 0; i--)
    {
        int temp = num % 2;
        num /= 2;
        binaryNum[i] = temp;
    }
    return binaryNum;
}

void PrintBinary(int[] binary)
{
    for (int i = 0; i < binary.Length; i++)
    {
        Console.Write(binary[i]);
    }
}

int num = Reader();
switch (num)
{
    case -1:
        Console.WriteLine("invalid number format");
        break;
    default:
        int count = CountDifiner(num);
        PrintBinary(BinaryNumConverter(num, count));
        break;
}