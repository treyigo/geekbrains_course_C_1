using System;
// Описываем делегат. В делегате описывается сигнатура методов, на
// которые он сможет ссылаться в дальнейшем (хранить в себе)
public delegate double Fun(double x);
public delegate double Fun2(double a, double x);

class Program
{
    // Создаем метод, который принимает делегат
    // На практике этот метод сможет принимать любой метод
    // с такой же сигнатурой, как у делегата
    public static void Table(Fun F, double x, double b)
    {
        Console.WriteLine("----- X ----- Y -----");
        while (x <= b)
        {
            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
            x += 1;
        }
        Console.WriteLine("---------------------");
    }
    public static void Table2(Fun2 F2, double a, double x, double b)
    {
        Console.WriteLine("----- X ----- Y -----");
        while (x <= b)
        {
            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F2(a,x));
            x += 1;
        }
        Console.WriteLine("---------------------");
    }

    // Создаем метод для передачи его в качестве параметра в Table
    public static double MyFunc(double x)
    {
        return x * x * x;
    }

    // Создаем метод для передачи его в качестве параметра в Table
    public static double MyFunc2(double a, double x)
    {
        return a * Math.Sin(x);
    }
    public static double MyFunc3(double a, double x)
    {
        return a * Math.Pow(x,2);
    }

    static void Main()
    {
        // Создаем новый делегат и передаем ссылку на него в метод Table
        Console.WriteLine("Таблица функции 4*sin(x):");          
        Table2(MyFunc2, 4, -2, 2);
        Console.WriteLine("Таблица функции 3*x^2:");
        // Упрощение(с C# 2.0). Использование анонимного метода
        Table2(delegate (double a, double x) { return a *  Math.Pow(x, 2); }, 3, 0, 3);
        Console.ReadKey();
    }
}
