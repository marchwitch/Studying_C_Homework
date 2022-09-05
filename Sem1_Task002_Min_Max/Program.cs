// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = 0;
int min = 0;

if (number2 < number1)
{
    max = number1;
    min = number2;
}
else
{
    max = number2;
    min = number1;
}

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);