//студент Игорь Третьяков, класс для работы с массивом

using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace CoolArray
{
    class MyArray
    {
        private int[] a;
        private int sum;
        private int maxCount;
        public MyArray(int size, int start, int step)
        {
            int value = start;
            a = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = value;
                value += step;
            }
        }
        public MyArray(int[] init)
        {
            int size = init.Length;
            a = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = init[i];
            }

        }
        public int Max
        {
            get
            {
                return a.Max();
            }
        }
        public int Sum
        {
            get
            {
                int sum = 0;
                foreach (int el in a)
                    sum += el;
                return sum;
            }
        }
        public int MaxCount
        {
            get
            {
                int maxCount = 0;
                int maxValue = a.Max();
                foreach (int el in a)
                    if (el == maxValue)
                    {
                        maxCount++;
                    }
                return maxCount;
            }
        }

        public void Multi(int k)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] *= k;
        }

        public MyArray Inverse()
        {
            MyArray copy = new MyArray(a);
            for (int i = 0; i < a.Length; i++)
                copy[i] *= -1;
            return copy;
        }

        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }

        public void Print()
        {
            foreach (int el in a)
                Console.Write("{0,4}", el);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray array1 = new MyArray(5, 0, 2);
            array1.Print();
            Console.WriteLine($"Сумма элементов:{array1.Sum}");
            Console.WriteLine($"Количество максимальных элементов:{array1.MaxCount}");
            array1.Multi(2);
            array1.Print();
            MyArray array2 = array1.Inverse();
            array1.Print();
            array2.Print();
            Console.ReadKey();
        }
    }
}
