using System;

namespace sortThreeNumbers
{
    class sortThreeNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Type in number a: ");
            double numberA = double.Parse(Console.ReadLine());
            Console.Write("Type in number b: ");
            double numberB = double.Parse(Console.ReadLine());
            Console.Write("Type in number c: ");
            double numberC = double.Parse(Console.ReadLine());

            if (numberA > numberB && numberA > numberC)
            {
                if (numberB > numberC)
                {
                    Console.WriteLine("Sorted numbers are a: {0}, b: {1}, c: {2}", numberA, numberB, numberC);
                }
                if (numberC > numberB)
                {
                    Console.WriteLine("Sorted numbers are: a: {0}, c: {1}, b: {2}", numberA, numberC, numberB);
                }
            }
            else if (numberB > numberA && numberB > numberC)
                {
                    if (numberA > numberC)
                    {
                        Console.WriteLine("Sorted numbers are: b: {0}, a: {1}, c: {2}", numberB, numberA, numberC);
                    }
                    if (numberC > numberA)
                    {
                        Console.WriteLine("Sorted numbers are: b: {0}, c: {1}, a: {2}", numberB, numberC, numberA);
                    }
                
                }
            else if (numberC > numberA && numberC > numberB)
            {
                if (numberA > numberB)
                {
                    Console.WriteLine("Sorted numbers are: c: {0}, a: {1}, b: {2}", numberC, numberA, numberB);
                }
                if (numberB > numberA)
                {
                    Console.WriteLine("Sorted numbers are: c: {0}, b: {1}, a: {2}", numberC, numberB, numberA);
                }

            }
            else
            {
                Console.WriteLine("Pesho");
            }
        }
    }
}
