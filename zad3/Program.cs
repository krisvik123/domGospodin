using System;
using System.Text.RegularExpressions;
namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<date>\d{2})\W(?<month>\w{3})\W(?<year>\d{4})");
            string input = Console.ReadLine();
            MatchCollection match = regex.Matches(input);
            foreach (Match m in match)
            {
                Console.WriteLine($"Day: {m.Groups["date"].Value}, Month: {m.Groups["month"].Value}, Year: {m.Groups["year"].Value}");
            }
        }
    }
}