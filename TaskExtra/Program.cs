// Дан целочисленный двумерный массив, размерности n х m. Найти номера нечетных элементов, стоящих на четных местах
// примем в условии, что чётное место = m и n должны быть чётными

Console.WriteLine("Введите количество строк массива:");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
FindNums(array);
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

void FindNums(int[,] arrayA)
{
    for (int i = 0; i < arrayA.GetLength(0); i += 2)
    {
        for (int j = 0; j < arrayA.GetLength(1); j += 2)
        {
            if (arrayA[i, j] % 2 == 1)
            {
                Console.WriteLine($"Нечётный элемент {arrayA[i, j]}, стоящий на чётном месте с индексом [{i}, {j}]");
            }
        }
    }
}


// Нечетный элемент, стоящий на четном месте c индексом [0,0]
// Нечетный элемент, стоящий на четном месте c индексом [0,2]
// Нечетный элемент, стоящий на четном месте c индексом [0,4]
// Нечетный элемент, стоящий на четном месте c индексом [2,0]
// Нечетный элемент, стоящий на четном месте c индексом [2,4]
// Нечетный элемент, стоящий на четном месте c индексом [4,4]
// Console.WriteLine($"Нечетный элемент, стоящий на четном месте c индексом [{i},{j}]");
