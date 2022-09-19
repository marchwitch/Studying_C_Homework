// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

int[] CreateArray()
{
    int[] array = new int[new Random().Next(5, 15)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,20);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}

int FindSumOfNumbersOddIndex(int[] collection)
{
    int sum = 0;
    for (int i = 1; i < collection.Length; i++)
    {
      if(i % 2 == 1)
      {
        sum += collection[i];
      }
    }
    return sum;
}

int[] arr = CreateArray();
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {FindSumOfNumbersOddIndex(arr)}");