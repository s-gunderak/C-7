// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int AskNumber(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

void FillArray(int[,] arr, int minValue, int maxValue)
{
    Random rand = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(minValue, maxValue);
        }
    }
}

void PrintNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int SumDiagonalNumbers(int[,] arr)
{
    int res = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                res += arr[i, j];
            }
        }
    }

    return res;
}

int rows = AskNumber("Enter rows: ");
int cols = AskNumber("Enter columns: ");
int minValue = AskNumber("Введите минимальное значение: ");
int maxValue = AskNumber("Введите максимальное значение: ");

int[,] arr = new int[rows, cols];

FillArray(arr, minValue, maxValue);
PrintNumbers(arr);
int sumNums = SumDiagonalNumbers(arr);
Console.WriteLine("Сумма чисел на главной диагонали = " + sumNums);
