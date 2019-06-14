using System;

namespace multiplicationSign
{
    class multiplicationSign
    {
        static void Main(string[] args)
        {
            Console.Write("Type in number a: ");
            double numberA = double.Parse(Console.ReadLine());
            Console.Write("Type in number b: ");
            double numberB = double.Parse(Console.ReadLine());
            Console.Write("Type in number c: ");
            double numberC = double.Parse(Console.ReadLine());

            if (numberA + numberB + numberC < 0)
            {
                Console.WriteLine("-");
            }
            else if (numberA + numberB + numberC > 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("Gosho");
            }
        }
    }
}
