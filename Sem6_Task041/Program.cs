// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2; -1, -7, 567, 89, 223-> 3

int GetCount (int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) result++;
    }
    return result;
}

int[] CreateArray()
{
    int[] array = new int[new Random().Next(5, 15)];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите число: ");
        int answer = Convert.ToInt32(Console.ReadLine());
        array[i] = answer;
    }
    return array;
}

int[] collection = CreateArray();
int count = GetCount(collection);
Console.WriteLine($"Количество чисел больше 0 = {count}");