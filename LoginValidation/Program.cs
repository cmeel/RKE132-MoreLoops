using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!";
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."
            //kasutajal on kolm katset

            int failedTries = 0;

            while (failedTries < 3)
            {
                Console.WriteLine("sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();

                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                } 
                else
                {
                    failedTries++;
                    if (3 - failedTries == 0)
                    {
                        Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti!");
                    }
                    else
                    {
                        Console.WriteLine($"Vale kasutajatunnus või salasõna. Saad veel {3 - failedTries} korda proovida!");
                    }
                }

            }
            Console.WriteLine("Sisestasid kasutajatunnust või salasõna 3 korda valesti. Oled blokeeritud!");
        }
    }
}
