using System;

namespace Inlämingsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Tal = new Random();
            int tal = Tal.Next(100);

            int gissningar = 0;
            bool Vinna = false;
            while(Vinna == false){
            Console.Write("Gissa på ett tal mellan 1 och 100: ");
            string gissning = (Console.ReadLine());
                int.TryParse(gissning, out int Gissning);
                gissningar++;
            
            if(Gissning==tal){
                Vinna=true;
                Console.WriteLine("Rätt");
                Console.WriteLine("Antal gissningar är:" + gissningar);
            }
                else if(Gissning>tal){
                    Console.WriteLine("Gissningen är för hög");
                }

                else if(Gissning<tal){
                    Console.WriteLine("Gissningen är för låg");
                }
            }
        }
    }
}

