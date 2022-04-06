using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrolli, kumb mängija viskas rohkem;
            //mängija, kes viskab rohkem, ongi mängu võitja;
            //*täringuid visatakse kolm korda
            //programm kuulutab võitja.

            Console.WriteLine("Viskame täringuid! Vajuta ENTER-it, et mängu alustada.");
            Console.ReadKey();

            Random rnd = new Random();

            int cpuRandom = 0;
            int userRandom = 0;

            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++)
            {
                cpuRandom = rnd.Next(1, 7);
                userRandom = rnd.Next(1, 7);
                Console.WriteLine(($"Arvuti viskas {cpuRandom}, kasutaja viskas {userRandom}"));
                Console.WriteLine("Vajuta ENTER-it, et veel täringuid visata.");
                Console.ReadKey();
            }
            if (cpuRandom < userRandom)
            {

                Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                userScore = userScore + 1;
            }
            else if (cpuRandom > userRandom)
            {
                Console.WriteLine("Arvuti on mängu võitnud.");
                cpuScore = cpuScore + 1;
            }
            else
            {
                Console.WriteLine("Viik!");
            }
        } 
    }
}
