using System;

namespace biggestOfFiveNumbers
{
    class biggestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Type in number a: ");
            double numberA = double.Parse(Console.ReadLine());
            Console.Write("Type in number b: ");
            double numberB = double.Parse(Console.ReadLine());
            Console.Write("Type in number c: ");
            double numberC = double.Parse(Console.ReadLine());
            Console.Write("Type in number d: ");
            double numberD = double.Parse(Console.ReadLine());
            Console.Write("Type in number e: ");
            double numberE = double.Parse(Console.ReadLine());

            if (numberA > numberB && numberA > numberC && numberA > numberD && numberA > numberE)
            {
                    Console.WriteLine("Biggest number is A = {0}", numberA);
            }
            else if (numberB > numberA && numberB > numberC && numberB > numberD && numberB > numberE)
            {
                    Console.WriteLine("Biggest number is B = {0}", numberB);
            }
            else if (numberC > numberA && numberC > numberB && numberC > numberD && numberC > numberE)
            {
                    Console.WriteLine("Biggest number is C = {0}", numberC);
            }
            else if (numberD > numberA && numberD > numberB && numberD > numberC && numberD > numberE)
            {
                Console.WriteLine("Biggest number is D = {0}", numberD);
            }
            else if (numberE > numberA && numberE > numberB && numberE > numberC && numberE > numberD)
            {
                Console.WriteLine("Biggest number is E = {0}", numberE);
            }
            else
            {
                Console.WriteLine("Gosho");
            }
        }
    }
}
