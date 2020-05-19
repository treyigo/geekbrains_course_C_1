using System;
using System.Text;
using System.Globalization;
//using System.Linq;
//using System.Net.Http;
using System.Collections.Generic;

//Автор - студент Игорь Третьяков, задание "статический класс Message"
class Comp : IComparer<string>
{
    public int Compare(string a, string b)
    {
        if (a.Length == b.Length) return 0;
        return a.Length < b.Length ? -1 : 1;
    }
}

static class Message
{
    static public string[] Words(string message)
    {
        char[] div = { ' ', '.', ',', '!', '?', '»', '«', ':', '-'};
        string[] words = message.Split(div, StringSplitOptions.RemoveEmptyEntries);
        return words;
    }
    static public string MyJoin(string[] words, string separator)
    {
        StringBuilder combine = new StringBuilder();
        int i = 0;
        while (i < (words.Length-1))
        {
            combine.Append(words[i]);
            combine.Append(separator);
            i++;
        }
        combine.Append(words[i]);
        return combine.ToString();
    }
    static public string[] ShortWords(string[] words, int max_len)
    {
        List<string> short_words  = new List<string>();
        foreach (string word in words)
        {
            Boolean isShort = word.Length <= max_len;
            if (isShort)
                short_words.Add(word);
        }
        return short_words.ToArray();
    }
    static public string[] LongWords(string[] words, int min_len)
    {
        List<string> long_words = new List<string>();
        foreach (string word in words)
        {
            Boolean isShort = word.Length >= min_len;
            if (isShort)
                long_words.Add(word);
        }
        return long_words.ToArray();
    }
    static public string[] CropWords(string[] words, char c)
    {
        List<string> select_words = new List<string>();
        foreach (string word in words)
        {
            Boolean isSelect = word.EndsWith(c);
            if (!isSelect)
                select_words.Add(word);
        }
        return select_words.ToArray();
    }

}

class Program
{
    static void Main()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Console.InputEncoding = Encoding.GetEncoding(1251);
        Console.WriteLine("Введите сообщение");
        String message = Console.ReadLine();
        string[] words = Message.Words(message);

        Console.WriteLine("Введите максимальную длину слова");
        int max_len = Convert.ToInt32(Console.ReadLine());
        string[] short_words = Message.ShortWords(words, max_len);
        string str_short_words = String.Join(" ", short_words);
        Console.WriteLine($"Короткие слова: {str_short_words}");
        
        Console.WriteLine("Введите запретный последний символ");
        char last_char = Convert.ToChar(Console.ReadLine());
        string[] crop_words = Message.CropWords(words, last_char);
        string str_crop_words = String.Join(" ", crop_words);
        Console.WriteLine($"Порезанный текст: {str_crop_words}");

        string[] sort_words = new string[words.Length];
        Array.Copy(words, sort_words, words.Length);
        Array.Sort(sort_words, new Comp());
        Array.Reverse(sort_words);
        string str_sort_words = String.Join(" ", sort_words);
        string str_words = String.Join(" ", words);
        Console.WriteLine($"Сортированный: {str_sort_words}");
        Console.WriteLine($"Проверка, не изменился ли старый массив: {str_words}");
        Console.WriteLine($"Самое длинное слово: {sort_words[0]}");

        Console.WriteLine("Введите мминимальную длину слова");
        int min_len = Convert.ToInt32(Console.ReadLine());
        string[] long_words = Message.LongWords(words, min_len);
        string str_long_words = String.Join(" ", long_words);
        Console.WriteLine($"длинные слова: {str_long_words}");
        string my_str_long_words = Message.MyJoin(long_words, " ");
        Console.WriteLine($"длинные слова с использованием самописного Join: {my_str_long_words}");
        Console.ReadKey();
    }
}