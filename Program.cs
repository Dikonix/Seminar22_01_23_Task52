void CreateRandomArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
}

void ShowArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void CalculateAverage(int[,] arr)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }
        double average = sum / arr.GetLength(0);
        Console.Write($"{average:f1}; ");
    }
}

const int numberOfLines = 5;
const int numberOfColumns = 4;
int[,] array = new int[numberOfLines, numberOfColumns];

CreateRandomArray(array);
ShowArray(array);
CalculateAverage(array);