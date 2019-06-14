using System;

namespace biggestOfThreeNums
{
    class biggestOfThreeNums
    {
        static void Main(string[] args)
        {
            Console.Write("Type in number a: ");
            double numberA = double.Parse(Console.ReadLine());
            Console.Write("Type in number b: ");
            double numberB = double.Parse(Console.ReadLine());
            Console.Write("Type in number c: ");
            double numberC = double.Parse(Console.ReadLine());

            if (numberA > numberB)
            {
                if (numberA > numberC)
                {
                    Console.WriteLine("Biggest number is A = {0}", numberA);
                }
            }
            if (numberB > numberA)
            {
                if (numberB > numberC)
                {
                    Console.WriteLine("Biggest number is B = {0}", numberB);
                }
            }
            if (numberC > numberA)
            {
                if (numberC > numberB)
                {
                    Console.WriteLine("Biggest number is C = {0}", numberC);
                }
            }
            else
            {
                Console.WriteLine("Gosho");
            }
        }
    }
}
