using System;
using System.Text;
using System.Globalization;

//Автор - студент Игорь Третьяков, задание "вычисление расстояния между двумя точками"
class Program
{
    static void Main()
    {
        CultureInfo ci = new CultureInfo("ru");

        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Console.InputEncoding = Encoding.GetEncoding(1251);

        Console.WriteLine("Введите координату Х первой точки");
        double x1 = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

        Console.WriteLine("Введите координату Y первой точки");
        double y1 = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

        Console.WriteLine("Введите координату X второй точки");
        double x2 = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

        Console.WriteLine("Введите координату Y второй точки");
        double y2 = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

        double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        string formatR = r.ToString("f2", CultureInfo.InvariantCulture);
        
        Console.WriteLine($"Расстояние между точками составляет {formatR}");
        Console.ReadKey();
    }
}

