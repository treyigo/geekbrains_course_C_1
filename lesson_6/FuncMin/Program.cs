using System;
using System.IO;
using System.Text;
using System.Globalization;

namespace DoubleBinary
{
    public delegate double Fun(double x);

    class Program
    {

        static double ReadNumber()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.InputEncoding = Encoding.GetEncoding(1251);
            return Convert.ToDouble(Console.ReadLine().Replace(".", ","));
        }

        public static double F1(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static void SaveFunc(string fileName, Fun F, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        static void Main()
        {
            Fun[] functionsArray = {
                delegate (double x) { return Math.Pow(x, 2); },
                delegate (double x) { return Math.Sin(x); },
                delegate (double x) { return Math.Exp(x); }
            };
            Console.WriteLine(@"Выберите функцию, введя eё номер:
                1) х^2
                2) sin(x)
                3) exp(x)"
);
            int functionNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стартовое значение анализируемого интревала:");
            double start = ReadNumber();
            Console.WriteLine("Введите конечное значение анализируемого интревала:");
            double end   = ReadNumber();

            SaveFunc("data.bin", functionsArray[functionNumber-1], start, end, 0.5);
            Console.WriteLine($"Минимальное значение функции на интервале: {Load("data.bin")}");

            Console.ReadKey();
        }
    }
}
