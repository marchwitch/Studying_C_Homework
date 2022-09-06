// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

FindThirdDigit(number1);

void FindThirdDigit(int num1)
{
    if(num1 > 99)
    {
        if(num1 < 1000)
        {
            int num2 = num1 % 10;
            Console.WriteLine($"Третья цифра {num2}");
        }
        else
        {
            int num3 = num1 / 10;
            while(num3 > 1000)
            {
                num3 = num3 / 10;
            }
            int num4 = num3 % 10;
            Console.WriteLine($"Третья цифра {num4}");
        }
    }
    else
    {
        Console.WriteLine("третьей цифры нет");
    }
}