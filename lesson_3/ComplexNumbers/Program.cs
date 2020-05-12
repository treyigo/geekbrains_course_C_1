//студент Игорь Третьяков, задача о доработке классса комплексных чисел

using System;
using System.Text;
using System.Globalization;

class Complex
{
    // Поля приватные.
    private double im;
    // По умолчанию элементы приватные, поэтому private можно не писать.
    double re;

    // Конструктор без параметров.
    public Complex()
    {
        im = 0;
        re = 0;
    }

    // Конструктор, в котором задаем поля.    
    public Complex(double _im, double _re)
    {           
        im = _im;
        re = _re;
    }
    public Complex Plus(Complex x2)
    {
        Complex x3 = new Complex();
        x3.im = x2.im + im;
        x3.re = x2.re + re;
        return x3;
    }

    public Complex Minus(Complex x2)
    {
        Complex x3 = new Complex();
        x3.im = im - x2.im;
        x3.re = re - x2.re;
        return x3;
    }

    public Complex Mult(Complex x2)
    {
        Complex x3 = new Complex();      
        x3.re = re*x2.re - im*x2.im;
        x3.im = im*x2.re + re*x2.im;
        return x3;
    }

    // Свойства - это механизм доступа к данным класса.
    public double Im
    {
        get { return im; }
        set
        {
            // Для примера ограничимся только положительными числами.
            if (value >= 0) im = value;
        }
    }

    public string ToString()
    {
        CultureInfo ci = new CultureInfo("ru");
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        string format_re = re.ToString("F1", CultureInfo.InvariantCulture);
        string format_im = im.ToString("F1", CultureInfo.InvariantCulture);
        return $"{format_re}+{format_im}i";
    }

}
class Program
{
    static double read_number()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Console.InputEncoding = Encoding.GetEncoding(1251);
        return Convert.ToDouble(Console.ReadLine().Replace(".", ","));
    }
    static void Main()
    {
        Console.WriteLine("Введите действительную часть первого числа:");
        double re1 = read_number();
        Console.WriteLine("Введите мнимую часть первого числа:");
        double im1 = read_number();
        Console.WriteLine("Введите действительную часть второго числа:");
        double re2 = read_number();
        Console.WriteLine("Введите мнимую часть второго числа:");
        double im2 = read_number();

        Complex complex1 = new Complex(im1, re1);
        Complex complex2 = new Complex(im2, re2);

        Console.WriteLine("Выберите операцию, которую вы хотие сделать с числами. 1 - сложить, 2 - вычесть, 3 - умножить, 0 - выход из программы.");

        int key = 0;
        do
        {
            key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 0:
                    break;
                case 1:
                    Complex result_plus = complex1.Plus(complex2);
                    Console.WriteLine($"Сумма равна: {result_plus.ToString()}");
                    break;
                case 2:
                    Complex result_minus = complex1.Minus(complex2);
                    Console.WriteLine($"Разность равна: {result_minus.ToString()}");
                    break;
                case 3:
                    Complex result_mult = complex1.Mult(complex2);
                    Console.WriteLine($"Произведение равно: {result_mult.ToString()}");
                    break;
                default:
                    break;
            }
        } while (key != 0);
    }
}
