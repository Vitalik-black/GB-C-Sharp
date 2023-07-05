// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int Input()
{
    Console.Write("Введите: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[] Solution(int num)
{
    int[] res = new int[] {};
    int i = 0;
    while (num > 0)
    {   
        Array.Resize(ref res, res.Length + 1);    
        res[i] = num % 2;
        num = num /2;
        i++;    
    }
    return res;
}
int[] ReverseArray2(int[] inArray)
{
    int[] res = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        res[i] = inArray[inArray.Length - 1 - i];
        Console.Write($"{res[i]}");
    }
    return res;
}
int num1 = Input();
int[] newArray = Solution(num1);
ReverseArray2(newArray);