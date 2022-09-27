// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    Console.WriteLine("Двумерный массив:");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]}\t");
        }
        Console.WriteLine();
    }
}

double[] FindAverageByColumns(int[,] collection)
{
    double[] average = new double[collection.GetLength(1)];
    for (int j = 0; j < collection.GetLength(1); j++)
    {
        double temp = 0;
        double row = collection.GetLength(0);
        for (int i = 0; i < collection.GetLength(0); i++)
        {
            temp += collection[i,j];
            average[j] = Math.Round(temp / row, 1);
        }
    }
    return average;
}

void ShowArray(double[] numbers)
{
    Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]}\t");
    }
}

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[rows,columns];

FillArray(array);
PrintArray(array);
Console.WriteLine();
double[] arr = FindAverageByColumns(array);
ShowArray(arr);