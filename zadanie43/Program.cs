// Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
double b1 = inputNumber("Введите значение b1");
double k1 = inputNumber("Введите значение k1");
double b2 = inputNumber("Введите значение b2");
double k2 = inputNumber("Введите значение k2");
result(b1, k1, b2, k2);




void result(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    System.Console.WriteLine($"({x}; {y})");
}


double inputNumber(string str)
{
    double number;
    string text;

    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();
        if (double.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}


