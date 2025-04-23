using System.ComponentModel;

namespace ConvertNumToWords
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number to convert to words:");
            string input = Console.ReadLine();
            int inputnumber = int.Parse(input);
            Console.WriteLine(inputnumber);
            
            /*if (int.TryParse(input, out int number))
            {
                string result = ConvertNumber(number);
                Console.WriteLine($"The number {number} in words is: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            */

        }
    }
}
