using System;

namespace ConvertNumToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to convert to words:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number >= 0) 
                {
                    try
                    {
                        string result = NumberToWords(number);
                        Console.WriteLine($"The number {number} in words is: {result}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error during conversion: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a non-negative number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words.Trim();
        }
    }
}
