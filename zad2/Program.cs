using System;
using System.Text.RegularExpressions;
namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\+359[ -]\d[ -]\d{3}[ -]\d{4}";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}