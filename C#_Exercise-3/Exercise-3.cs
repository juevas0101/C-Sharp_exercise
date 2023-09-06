using System.Runtime.InteropServices;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Make a program for paying commissions to parts sellers, taking into account that your
               commission will be 5 % of the total sale and that you have the following data:
               -Seller identification
               - part code
               - Unit price of the piece
               - Sold amount */

            string seller, partCode;
            double pricePart, commission;
            int soldQuantity;

            Console.Write("What's your name: ");
            seller = Console.ReadLine();

            Console.Write("Enter the part code: ");
            partCode = Console.ReadLine();

            Console.Write("Enter the price of the part: ");
            if (double.TryParse(Console.ReadLine(), out pricePart))
            {
                Console.Write("Enter the sold quantity of the part: ");
                if (int.TryParse(Console.ReadLine(), out soldQuantity))
                {
                    commission = (pricePart * soldQuantity) * 0.05;

                    Console.WriteLine($"Seller: {seller}");
                    Console.WriteLine($"Part Code: {partCode}");
                    Console.WriteLine($"Price of the Part: {pricePart:F2}");
                    Console.WriteLine($"Sold Quantity: {soldQuantity}");
                    Console.WriteLine($"{seller}, your commission is: {commission:F2}");
                }
                else
                {
                    Console.WriteLine("Invalid quantity. Please enter a valid integer.");
                }
            }
            else
            {
                Console.WriteLine("Invalid price. Please enter a valid number.");
            }
        }
    }
}