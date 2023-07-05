/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
 3, 5 -> 243 (3⁵)
 2, 4 -> 16 */

 Console.Clear();


const string superscriptDigits = "\u207B\u2070\u00b9\u00b2\u00b3\u2074\u2075\u2076\u2077\u2078\u2079";
double numA = 0;
int tryCount = 3, numB = 0;
string inputStr = string.Empty;
string[] inputNumbers = { };
bool resInputCheck = false;
double result = 1;

while (!resInputCheck)
{
Console.WriteLine($"\r\nВведите число А и натуральное число В через пробел (Оставшееся количество попыток: {tryCount}):");
inputStr = Console.ReadLine()!;
inputNumbers = inputStr.Split(new char[] { ' ', ';', '.', '/' });

resInputCheck = inputNumbers.Length == 2 && double.TryParse(inputNumbers[0], out numA) && int.TryParse(inputNumbers[1], out numB) && numB > 0;

if (!resInputCheck)
{
tryCount--;

if (tryCount == 0)
{
Console.WriteLine("\r\n Вы исчерпали все попытки.\r\nВыполнение программы будет остановлено.");
return;
}
}
}

result = Pow(numA, numB);

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine($"{numA}{NumberToSuperscript(numB)} - (число A в натуральной степени B равно) --> {Math.Round(result, 4)}");

double Pow(double num, int degree)
{
    double res = 1;
    for (int i = 0; i < numB; i++)
    {
        res *= numA;
    }

    return res;
}

string NumberToSuperscript (int num)
{
    string result = string.Empty;

    bool isNegative = num < 0;

    int n = Math.Abs (num);
    while (n > 0)
    {
        result = superscriptDigits[n % 10 + 1] + result;
        n /= 10;
    }

    return isNegative ? superscriptDigits[0] + result : result;
}