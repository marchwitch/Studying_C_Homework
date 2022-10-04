// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма натуральных элементов в промежутке от M до N:");
Console.WriteLine(SumNumbersFromMToN(number1, number2));

int SumNumbersFromMToN(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    return(start + SumNumbersFromMToN(start + 1, end));
}