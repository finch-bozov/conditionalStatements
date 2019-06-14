using System;
namespace exchangeIfGreater
{
    class exchangeIfGreater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a number for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Type in a number for b: ");
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
                Console.WriteLine("This is number a: {0} and this is number b: {1} after they have been exchanged", a, b);
            }
            else
            {
                Console.WriteLine("Gosho");
            }
        }
    }
}
