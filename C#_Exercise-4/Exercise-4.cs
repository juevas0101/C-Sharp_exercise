namespace C__Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Read four integer numerical values ​​and present the result two by two of the addition and multiplication between the
             values ​​read, based on the use of the concept of distributive property. Hint: if the variables are read
             A, B, C and D, the values ​​of A with B, A with C and A with D must be added and multiplied; then B with C, B
             with D and finally C with D. Note that for each operation six combinations will be used. Consequently,
             twelve processing operations must be carried out, six for the additions and six for the
             multiplications.*/
            int a, b, c, d;

            Console.Write("Enter the value of A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter the value of B: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Enter the value of C: ");
            c = int.Parse(Console.ReadLine());

            Console.Write("Enter the value of D: ");
            d = int.Parse(Console.ReadLine());

            int sumAB = a + b;
            int sumAC = a + c;
            int sumAD = a + d;
            int sumBC = b + c;
            int sumBD = b + d;
            int sumCD = c + d;

            int productAB = a * b;
            int productAC = a * c;
            int productAD = a * d;
            int productBC = b * c;
            int productBD = b * d;
            int productCD = c * d;

            Console.WriteLine($"Sum AB: {sumAB}");
            Console.WriteLine($"Sum AC: {sumAC}");
            Console.WriteLine($"Sum AD: {sumAD}");
            Console.WriteLine($"Sum BC: {sumBC}");
            Console.WriteLine($"Sum BD: {sumBD}");
            Console.WriteLine($"Sum CD: {sumCD}");

            Console.WriteLine($"Product AB: {productAB}");
            Console.WriteLine($"Product AC: {productAC}");
            Console.WriteLine($"Product AD: {productAD}");
            Console.WriteLine($"Product BC: {productBC}");
            Console.WriteLine($"Product BD: {productBD}");
            Console.WriteLine($"Product CD: {productCD}");
        }
    }
}