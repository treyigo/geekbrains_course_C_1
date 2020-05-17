//Студент Третьяков Игорь, статический класс для работы с массивом

using System;
using System.Data;

static class StaticClass
{
    public static void FillRandomNumber(int[] a, int min, int max)
    {
        for (int i = 0; i<a.Length; i++)
        {
            Random rnd = new Random();
            a[i] = rnd.Next(min, max);
        }
        //
    }
    public static int CountPairs(int[] a)
    {
        int count = 0;
        for (int i = 0; i < a.Length-1; i++)
        {
            if ((a[i] % 3 == 0) ^ (a[i+1] % 3 == 0))   
                count++;
        }
        return count;
    }
    public static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0} ", a[i]);
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        int[] testArray = new int[20];
        StaticClass.FillRandomNumber(testArray, -10000, 10000);
        StaticClass.Print(testArray);
        int result = StaticClass.CountPairs(testArray);
        Console.Write($"result:{result}");
        Console.ReadKey();
    }
}
