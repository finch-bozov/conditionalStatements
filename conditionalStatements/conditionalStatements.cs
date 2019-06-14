using System;

namespace conditionalStatements
{
    class conditionalStatements
    {
        static void Main(string[] args)
        {
            // if (condition) = condition can be bool / bool logical expression or comparison
            bool firstExampleResult = 6 > 5;
            bool secondExampleResult = 8 < 4;

            if (firstExampleResult && secondExampleResult)
            {
                Console.WriteLine("Pet e po-golqmo ot shes");
            }

            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            if (age > 10 && age < 50)
            {
                Console.WriteLine("Age is > 10");
            }

            Console.Write("Enter number: ");
            int evenOrOddNumber = int.Parse(Console.ReadLine());

            if (evenOrOddNumber % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }

            Console.Write("Type name of person: ");
            string nameOfPerson = Console.ReadLine();

            if (nameOfPerson == "Pesho")
            {
                Console.WriteLine("Partiya");
            }
            else
            {
                Console.WriteLine("Sorry");
            }

            Console.WriteLine("1.New Game \n2.Load Game\n3.Quit");
            int mainMenuAction = int.Parse(Console.ReadLine());

            if (mainMenuAction == 1)
            {
                Console.WriteLine("Starting New Game... ");
            }
            else if (mainMenuAction == 2)
            {
                Console.WriteLine("Loading Game...");
            }
            else if (mainMenuAction == 3)
            {
                Console.WriteLine("Bye bye...!");
            }
            else
            {
                Console.WriteLine("Begay be");
            }

            Console.Write("What animal are you looking for? ");
            string animal = Console.ReadLine();
            switch (animal)
            {
                case "dog": Console.WriteLine("Mammal"); break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("Reptile"); break;
                default:
                    Console.WriteLine("{0} does not exist", animal);
                    break;
            }
        }
    }
}
