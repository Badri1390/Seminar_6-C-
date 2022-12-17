//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
int number = inputNumber("Задайте кол-во чисел");
int[] array = new int[number];
int res = Result(array);
System.Console.WriteLine($"Кол-во чисел больше нуля: {res}");

int Result(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {

        arr[i] = inputNumber("Введите число");
        if (arr[i] > 0)
        {
            count++;

        }

    }
    System.Console.WriteLine($"[{String.Join(", ", arr)}]");
    return count;

}

int inputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}

