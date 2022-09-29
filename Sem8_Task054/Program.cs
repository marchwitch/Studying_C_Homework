// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SortFromMaxToMin(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            for (int k = 0; k < collection.GetLength(1); k++)
            {
                if (collection[i, j] >= collection[i, k])
                {
                    int temp = collection[i, j];
                    collection[i, j] = collection[i, k];
                    collection[i, k] = temp;
                }
            }
        }
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
SortFromMaxToMin(array);
PrintArray(array);