// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.WriteLine("Введите количество строк массива:");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n, int mminValue, int maxValue)
{
    int[,] result = new int[m, n];//первая переменная задаёт строки, вторая - столбцы
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
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
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);