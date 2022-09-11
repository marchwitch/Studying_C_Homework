// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵); 2, 4 -> 16;

int Prompt (string message)
{
    Console.Write(message);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int RaiseDegree (int number1, int number2)
{
    int result = 1;
    for (int i = 0; i < number2; i++)
    {
        result *= number1;
    }
    return result;
}

int num1 = Prompt("Введите число 1: ");
int num2 = Prompt("Введите число 2: ");
Console.WriteLine(RaiseDegree(num1, num2));