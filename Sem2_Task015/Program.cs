// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7: ");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckDay(DayOfWeek));

bool CheckDay(int num)
{
    return num == 6 || num == 7;
}