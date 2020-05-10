using System;
using System.Text;
using System.Globalization;

//Автор - студент Игорь Третьяков, задание "подсчет суммы нечётных положительных чисел"
class Program
{
    static void Main()
    {
        int sum = 0;
        Console.WriteLine("Вводите числа. Введите 0, чтобы показать результат.");
        while (true)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 0)
                break;
            else if ((x > 0) && (x % 2 == 1))
                sum += x;
        }
        Console.WriteLine($"Сумма введённых нечётных положительных чисел равна {sum}");
        Console.ReadKey();
    }
}