using System;
using System.Text;

//Автор - студент Игорь Третьяков, задание "анкета"

class Program
{
    static void Main()
    {

        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Console.InputEncoding = Encoding.GetEncoding(1251);

        Console.WriteLine("Введите ваше имя");
        String name = Console.ReadLine();
        Console.WriteLine(value:"Введите ваш возраст");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Здравствуйте " + name + ", вам " + age + " лет.");
        Console.WriteLine("Здравствуйте {0}, вам {1} лет.", name, age);
        Console.WriteLine($"Здравствуйте {name}, вам {age} лет.");

        Console.ReadKey();
    }
}

