// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt (string message)
{
    Console.Write(message);
    double answer = Convert.ToDouble(Console.ReadLine());
    return answer;
}

void GetDotCross(double a, double b, double c, double d)
{
    double x = 0;
    double y = 0;

    // y = b * x + a;
    // y = d * x + c;
    // (b * x) + a = d * x + c;
    // (b * x) - d * x = c - a;

    x = (c - a) / (b - d);
    y = (b * x) + a;

    if((b * x) + a != d * x + c)
    {
        Console.WriteLine($"прямые не имеют пересечений");
    }
    else Console.WriteLine($"({x}; {y})");
}


double b1 = Prompt("Введите число b1: ");
double k1 = Prompt("Введите число k1: ");
double b2 = Prompt("Введите число b2: ");
double k2 = Prompt("Введите число k2: ");
GetDotCross(b1, k1, b2, k2);