// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вывод результата (натуральные числа в промежутке от N до 1): ");
Console.WriteLine(PrintNumbers(num, 1));

string PrintNumbers(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return(start + ", " + PrintNumbers(start - 1, end));
}