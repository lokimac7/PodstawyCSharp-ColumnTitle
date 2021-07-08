using System;

namespace ColumnTitle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ColumnTitle ct = new ColumnTitle();
            Console.WriteLine(ct.TitleToNumber("WAAAB"));
            Console.WriteLine(ct.TitleToNumber("AAAB"));
            Console.WriteLine(ct.TitleToNumber("ZZZZ"));
            Console.WriteLine(ct.TitleToNumber("ABCD"));
            Console.WriteLine(ct.TitleToNumber("KLASA"));
            Console.WriteLine(ct.TitleToNumber("wsd"));
            Console.ReadKey();
        }
    }

    public class ColumnTitle
    {
        public int TitleToNumber(string columnTitle)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int result = 0;

            foreach (var item in columnTitle.ToUpper())
            {
                int index = alphabet.IndexOf(item) + 1;
                result = result * 26 + index;
            }
            return result;
        }
    }
}
