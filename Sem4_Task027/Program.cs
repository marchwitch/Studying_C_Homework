// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11; 82 -> 10; 9012 -> 12

int Prompt (string message)
{
    Console.Write(message);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int SumOfDigits(int number)
{
    int sum = 0;
    
    if(number < 0) number = - number;

    while (number > 0)
    {
        int remain = number % 10;
        number = number / 10;
        sum += remain;
    }
    return sum;
}

int num = Prompt("Введите число > ");
Console.WriteLine($"Сумма цифр в числе равна {SumOfDigits(num)}");
