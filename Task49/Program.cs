// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.WriteLine("Введите количество строк массива:");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
MathPow(array);
Console.WriteLine();
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];//первая переменная задаёт строки, вторая - столбцы
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)//GetLength - это встроенный в язык метод, который определяет количество: (0) - строк, (1) - столбцов
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MathPow(int[,] arrayA)
{
    for (int i = 0; i < arrayA.GetLength(0); i += 2)
    {
        for (int j = 0; j < arrayA.GetLength(1); j += 2)
        {
            arrayA[i, j] = arrayA[i, j] * arrayA[i, j];
        }
    }
}