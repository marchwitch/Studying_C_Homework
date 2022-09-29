// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateArray()
{
    Console.WriteLine("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[rows,columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1, 10);
        }
    }
    return matrix;
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

int[,] MultiplyMatrix(int[,] matrix, int[,] matr)
{
    int[,] collection = new int[matrix.GetLength(0), matr.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(0); k++)
            {
                collection[i,j] += matrix[i,k] * matr[k,j];
            }
        }
    }
    return collection;
}

int[,] firstArray = CreateArray();
int[,] secondArray = CreateArray();


if (firstArray.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine("Данные матрицы нельзя перемножить, введите другие значения");
}
else
{
    Console.WriteLine("Первая матрица");
    PrintArray(firstArray);
    Console.WriteLine("Вторая матрица");
    PrintArray(secondArray);
    Console.WriteLine();
    int[,] coll = MultiplyMatrix(firstArray, secondArray);
    Console.WriteLine("Результирующая матрица:");
    PrintArray(coll);
}