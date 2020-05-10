using System;
using System.Text;
using System.Globalization;

//Автор - студент Игорь Третьяков, задание "метод подсчета количества цифр числа"
class Program
{
    static Boolean check(string username, string password)
    {
        string TRUE_USERNAME = "root";
        string TRUE_PASSWORD = "GeekBrains";
        if (username == TRUE_USERNAME)
        {
            if (password == TRUE_PASSWORD)
                return true;
            else
                return false;
        } else
            return false;
    }

    static void Main()
    {
        int MAX_CHECKS = 3;
        int attempt = 0;
        while (attempt < MAX_CHECKS)
        {
            Console.WriteLine("Введите имя пользователя");
            string username = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            string password = Console.ReadLine();
            
            if (check(username, password))
            {
                Console.WriteLine("Авторизация успешна");
                break;
            }
            else
            {
                attempt++;
                if (attempt == MAX_CHECKS)
                {
                    Console.WriteLine("Превышено допустимое число попыток авторизации. Доступ заблокирован.");
                }
                else
                {
                    int last = MAX_CHECKS - attempt;
                    Console.WriteLine($"Неврное сочетание логина и пароля. Осталось попыток: {last}");
                }
            }
        }
        Console.ReadKey();
    }
}