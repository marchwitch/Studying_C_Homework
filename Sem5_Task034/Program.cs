// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray()
{
    int[] array = new int[new Random().Next(5, 15)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
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

int FindNumberOfEvenNumbers(int[] collection)
{
    int amount = 0;
    for (int i = 0; i < collection.Length; i++)
    {
      if(collection[i] % 2 == 0)
      {
        amount++;
      }
    }
    return amount;
}

int[] arr = CreateArray();
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве = {FindNumberOfEvenNumbers(arr)}");