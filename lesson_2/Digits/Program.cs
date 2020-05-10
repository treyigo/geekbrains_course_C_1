using System;
using System.Text;
using System.Globalization;

//Автор - студент Игорь Третьяков, задание "метод подсчета количества цифр числа"
class Program
{
    static void print_result(int num)
    {
        int last_digit = num % 10;
        switch (last_digit)
        {
            case 1:
                Console.WriteLine($"Число содержит {num} цифру");
                break;
            case 2:
            case 3:
            case 4:
                Console.WriteLine($"Число содержит {num} цифры");
                break;
            default:
                Console.WriteLine($"Число содержит {num} цифр");
                break;
        }
    }

    static int digits(int number)
    {
        int d = 0;
        while (number != 0)
        {
            number /= 10;
            d++;
        }
        return d;
    }

    static void Main()
    {
        Console.WriteLine("Введите число");
        int x = Convert.ToInt32(Console.ReadLine());
        int result = digits(x);
        print_result(result);
        Console.ReadKey();
    }
}