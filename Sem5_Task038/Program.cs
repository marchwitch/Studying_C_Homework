// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateArray()
{
    double[] array = new double[new Random().Next(5, 15)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}

double VarianceMaxMin(double[] collection)
{
    double max = collection[0];
    for (int i = 1; i < collection.Length; i++)
    {
      if(collection[i] > max)
      {
        max = collection[i];
      }
    }

    double min = collection[0];
    for (int i = 1; i < collection.Length; i++)
    {
      if(collection[i] < min)
      {
        min = collection[i];
      }
    }
    double var = max - min;
    return var;
}

double[] arr = CreateArray();
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {VarianceMaxMin(arr)}");