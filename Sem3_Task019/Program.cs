// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

void FillArray(int [] collection, int Number)
{
    int size = collection.Length;
    int index = 0;
    while (index < size)
    {
        collection[index] = Number % 10;
        Number = Number / 10;
        index++;
    }
}

void CheckIfNumberIsAPalindrome (int [] array1)
{
    int index = 0;
    int size = array1.Length;
    if( array1[index] == array1[(size - 1)] && array1[(index+1)] == array1[(size - 2)])
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

int [] array = new int [5];
FillArray(array, number);
CheckIfNumberIsAPalindrome(array);

// void PrintArray(int [] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }
// PrintArray(array);