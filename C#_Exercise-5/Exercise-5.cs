namespace C__Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temp, distance, usedLiters, avarageSpeed;

            Console.WriteLine("Enter the time spent on the trip (hours)");
            temp = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter average speed (km/h): ");
            avarageSpeed = double.Parse(Console.ReadLine());

            distance = temp * avarageSpeed;

            usedLiters = distance / 12.0;

            Console.WriteLine($"Average speed: {avarageSpeed} Km/h");
            Console.WriteLine($"Time Spent on Travel: {temp} hours");
            Console.WriteLine($"Travelled distance: {distance} Km");
            Console.WriteLine($"Quantity of Liters Used: {usedLiters:F2} liters");
        }
    }
}