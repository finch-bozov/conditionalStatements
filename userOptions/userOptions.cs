using System;

namespace userOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a type: \n1. int\n2. double\n3.string");
            int userSelection = int.Parse(Console.ReadLine());

            if (userSelection == 1)
            {
                Console.Write("Enter an integer: ");
                int userInteger = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} + 1 equals = {1}", userInteger, userInteger + 1);
            }
            else if (userSelection == 2)
            {
                Console.Write("Enter an double: ");
                double userDouble = double.Parse(Console.ReadLine());
                Console.WriteLine("{0} + 1 equals = {1}", userDouble, userDouble + 1);
            }
            else if (userSelection == 3)
            {
                Console.Write("Enter an string: ");
                string userString = Console.ReadLine();
                Console.WriteLine("{0}*", userString);
            }
            else
            {
                Console.WriteLine("Goshenceto");
            }
        }
    }
}
