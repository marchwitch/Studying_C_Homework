// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round(new Random().NextDouble() * 10, 2);
        }
    }
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int rows = new Random().Next(3,6);
int columns = new Random().Next(3,6);
double[,] array = new double[rows,columns];

FillArray(array);
PrintArray(array);