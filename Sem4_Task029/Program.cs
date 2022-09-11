// Задача 29: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции.

int[] FillArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = new Random().Next(0, 100);  
    }
    return array;
}

void ShowArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
}

int[] collection = FillArray();
ShowArray(collection);
