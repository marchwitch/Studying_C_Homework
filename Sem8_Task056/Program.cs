// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int[] FindSumByRow(int[,] collection)
{
    int[] sum = new int[collection.GetLength(0)];
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        int summa = 0;
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            summa += collection[i,j];
            sum[i] = summa;
        }
    }
    return sum;
}

int FindMin(int[] collection)
{
    int min = collection[0];
    int index = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (min > collection[i])
        {
            min = collection[i];
            index = i;
        }
    }
    return index;
}

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

if(rows == columns)
{
    Console.WriteLine("Введены недопустимые значения");
}
else
{
    int[,] array = new int[rows,columns];

    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    int[] arr = FindSumByRow(array);
    Console.WriteLine($"Строка с наименьшей суммой элементов = {FindMin(arr)}");
}