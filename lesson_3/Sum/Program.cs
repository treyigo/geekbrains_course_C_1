using System;
using System.Text;
using System.Globalization;

//Автор - студент Игорь Третьяков, задание "подсчет суммы нечётных положительных чисел"
class Program
{
    static int GetValue()
    {
        int x;
        string s;
        bool flag;
        do
        {
            Console.WriteLine("Введите число:");
            s = Console.ReadLine();
            flag = int.TryParse(s, out x);
        }
        while (!flag);
        return x;
    }

    static void Main()
    {
        int sum = 0;
        Console.WriteLine("Программа подсчитывает сумму нечётных положительных чисел. Ввод 0 показывает результат и завершает программу.");
        while (true)
        {
            int x = GetValue();
            if (x == 0)
                break;
            else if ((x > 0) && (x % 2 == 1))
                sum += x;
        }
        Console.WriteLine($"Результат: {sum}");
        Console.ReadKey();
    }
}