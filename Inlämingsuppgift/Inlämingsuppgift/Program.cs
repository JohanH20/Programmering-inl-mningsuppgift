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
            int gissning = int.Parse(Console.ReadLine());
                gissningar++;
            
            if(gissning==tal){
                Vinna=true;
                Console.WriteLine("Rätt");
                Console.WriteLine("Antal gissningar är:" + gissningar);
            }
                else if(gissning>tal){
                    Console.WriteLine("Gissningen är för hög");
                }

                else if(gissning<tal){
                    Console.WriteLine("Gissningen är för låg");
                }
            }
        }
    }
}

