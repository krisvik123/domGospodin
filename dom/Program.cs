using System;
using System.Text.RegularExpressions;
namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Ivan Ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test Testov, Ivan   Ivanov";

            string pattern = @"\b[A-Z][a-z]* [A-Z][a-z]*";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}