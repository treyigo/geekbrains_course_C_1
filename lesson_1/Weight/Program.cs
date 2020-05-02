using System;
using System.Text;

//Автор - студент Игорь Третьяков, задание "калькулятор индекса массы дела"

class Program
{
    static void Main()
    {

        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Console.InputEncoding = Encoding.GetEncoding(1251);

        Console.WriteLine("Введите ваш вес в килограммах");
        double m = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

        Console.WriteLine("Введите ваш рост в метрах");
        double h = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

        double I = m / (h * h);

        Console.WriteLine($"Ваш индекс массы составляет {I}");
        Console.ReadKey();
    }
}

