// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number%2;
int temp = 0;

if (result == 0)
{
    while (temp < number)
    {
        temp += 2;
        Console.WriteLine(temp);
    }
}
else
{
    while (temp < number - 1)
    {
        temp += 2;
        Console.WriteLine(temp);
    }
}