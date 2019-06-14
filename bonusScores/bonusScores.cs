using System;

namespace bonusScores
{
    class bonusScores
    {
        static void Main(string[] args)
        {
            Console.Write("What is the score after the performance of the athlete: ");
            int scoreOfAthlete = int.Parse(Console.ReadLine());

            if (scoreOfAthlete >= 1 && scoreOfAthlete <= 3)
            {
                int timesTen = scoreOfAthlete * 10;
                Console.WriteLine("The score gets a multiplier * 10 and equals: {0}", timesTen);
            }
            else if (scoreOfAthlete >= 4 && scoreOfAthlete <= 6)
            {
                int timesHundred = scoreOfAthlete * 100;
                Console.WriteLine("The score gets a multiplier * 100 and equals: {0}", timesHundred);
            }
            else if (scoreOfAthlete >= 7 && scoreOfAthlete <= 9)
            {
                int timesThousand = scoreOfAthlete * 1000;
                Console.WriteLine("The score gets a multiplier * 1000 and equals: {0}", timesThousand);
            }
            else
            {
                Console.WriteLine("Invalid score!");
            }
        }
    }
}
