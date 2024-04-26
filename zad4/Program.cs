using System;
using System.Text.RegularExpressions;
namespace zad4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string pattern = @">>([A-Za-z]+)<<(\d+(\.\d+)?)!(\d+)";
            Regex regex = new Regex(pattern);

            double totalPrice = 0;

            Console.WriteLine("Enter your furniture:");
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Purchase")
                {
                    break;
                }

                Match match = regex.Match(input);

                if (match.Success)
                {
                    string mebeli = match.Groups[1].Value;
                    double cena = double.Parse(match.Groups[2].Value);
                    int quantity = int.Parse(match.Groups[4].Value);

                    totalPrice += cena * quantity;

                    Console.WriteLine($"Bought furniture: {mebeli}");
                }
            }

            Console.WriteLine($"Total money spent: {totalPrice:F2}");
        }

    }
}