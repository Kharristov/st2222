using System;

public class Program
{
    public static string TrimString(string phrase, int len)
    {
        if (len <= 3)
        {
            if (phrase.Length > len)
                return phrase.Substring(0, len) + "...";
            return phrase;
        }

        if (phrase.Length > len)
            return phrase.Substring(0, len - 3) + "...";
        return phrase;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(TrimString("Writing code is fun", 14));
        Console.WriteLine(TrimString("He", 1));
        Console.WriteLine(TrimString("Hello", 10));
    }
}