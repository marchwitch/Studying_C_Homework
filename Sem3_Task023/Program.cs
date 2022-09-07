// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
GetTableOfCubes(number);

void GetTableOfCubes(int num)
{
    int count = 1;
    while(count <= Math.Abs(num))
    {
        Console.WriteLine($"Куб числа {count} = {Math.Pow(count, 3)}");
        count++;
    }
}