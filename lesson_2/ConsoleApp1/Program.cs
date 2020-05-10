using System;
using System.Text;
using System.Globalization;

//Автор - студент Игорь Третьяков, задание "вычисление минимального из 3 чисел"
class Program
{
    static double read_number()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Console.InputEncoding = Encoding.GetEncoding(1251);
        return Convert.ToDouble(Console.ReadLine().Replace(".", ","));
    }

    static string format_number( double num)
    {
        CultureInfo ci = new CultureInfo("ru");
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        string format_num = num.ToString("F", CultureInfo.InvariantCulture);
        return format_num;
    }

    static double min(double n1, double n2, double n3)
    {
        if ((n1 < n2) && (n1 < n3))
            return n1;
        else if ((n2 < n1) && (n2 < n3))
            return n2;
        else
            return n3;
    }

    static void Main()
    {

        Console.WriteLine("Введите первое число");
        double x1 = read_number();

        Console.WriteLine("Введите второе число");
        double x2 = read_number();

        Console.WriteLine("Введите третье число");
        double x3 = read_number();

        string result = format_number(min(x1, x2, x3));

        Console.WriteLine($"Минимальное число равно {result}");
        Console.ReadKey();
    }
}