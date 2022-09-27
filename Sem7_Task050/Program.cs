// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void FindElement(int[,] collection, int k, int l)
{
    if(k < collection.GetLength(0) && l < collection.GetLength(1))
    {
        Console.WriteLine(collection[k,l]);
    }
    else
    {
        Console.WriteLine($"Такого элемента в массиве нет");
    }
}

Console.WriteLine("Введите номер строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int rows = new Random().Next(3, 7);
int columns = new Random().Next(3, 8);
int[,] array = new int[rows,columns];

FillArray(array);
PrintArray(array);
Console.WriteLine();
FindElement(array, m, n);