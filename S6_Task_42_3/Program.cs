int InPutNum(string message) // ввод данных
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Convert10To2(int num)
{
    int res = 0;
    string showresult = string.Empty;
    while (num > 0)
    {
        res = num % 2;
        num /= 2;
        showresult = res + showresult; // 0 + "пустое значени" // 0+0 // 0+00 // 1+000//
    }
    Console.WriteLine();
    Console.WriteLine(showresult);

}

int a = InPutNum("Введите число");
Convert10To2 (a);

// string res1=Convert.ToString(number,2);