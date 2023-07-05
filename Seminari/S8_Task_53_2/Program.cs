int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
    }
}

int[] FromMatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int e in array)
    {
        Console.Write(e + " ");
    }
    Console.WriteLine(string.Empty);
    Console.WriteLine(string.Empty);
}

int[,] matrix = GetMatrix(3, 4);
PrintMatrix(matrix);
Console.WriteLine(string.Empty);
Console.WriteLine(string.Empty);
int[] array = FromMatrixToArray(matrix);
PrintArray(array);

bool Comparsion(int[] array, int num)
{
    bool result = false;
    foreach (int e in array)
    {
        if (e == num)
        {
            result = true;
            break;
        }
        else result = false;
    }
    return result;
}

int[] tempArray = new int[array.Length];

for (int i = 0; i < tempArray.Length; i++)
{
    tempArray[i] = -1;
}

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (Comparsion(tempArray, array[i]) == true) continue;
    else
    {
        tempArray[i] = array[i];
        
        foreach (int e in array)
        {
            if (e == array[i]) count++;
        }
    }
    Console.WriteLine($"Число {array[i]} встречается {count} раз(а)");
    count = 0;
}