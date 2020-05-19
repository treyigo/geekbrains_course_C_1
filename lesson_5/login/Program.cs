using System;
using System.Text;
using System.Globalization;
using System.Linq;
using System.Net.Http;

//Автор - студент Игорь Третьяков, задание "проверка корректности ввода логина"
class Program
{

    static void Main()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Console.InputEncoding = Encoding.GetEncoding(1251);

        int MIN_LENGTH = 2;
        int MAX_LENGTH = 10;

        String message;
        do
        {
            Console.WriteLine("Введите логин");
            message = Console.ReadLine();
            int length = message.Length;
            if (message.All(Char.IsLetterOrDigit))
            {
                if (length > MIN_LENGTH)
                {
                    if (length < MAX_LENGTH)
                    {
                        if ((Char.IsLetter(message.ToCharArray()[0])))
                        {
                            Console.WriteLine("Логин корректен");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Логин начинается не с буквы");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Слишком длинный логин");
                    }
                } else
                {
                    Console.WriteLine("Слишком короткий логин");

                }
            }
            else
            {
                Console.WriteLine("Введены недопустимые символы");
            }

        } while (true);
        Console.ReadKey();
    }
}