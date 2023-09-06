namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Make a program that:
            - Read the dollar rate 
            - Read a value in dollars
            - Convert this value to Real
            - Show the result */

            double value, conversao;

            Console.WriteLine("Write the value to be converted: ");
            value = float.Parse(Console.ReadLine());

            conversao = value * 4.94;

            Console.WriteLine($"The conversion is about: {conversao:F2}");
        }
    }
}
