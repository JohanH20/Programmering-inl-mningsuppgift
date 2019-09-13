using System;

namespace Inlämingsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Random tal = new Random();
            int tal = tal.Random(100);

            bool Vinna = false;
            while(Vinna == false){
            Console.Write("Gissa på ett tal mellan 1 och 100: ");
            int gissning = int.Parse(Console.ReadLine());
            
            if(gissning==tal){
                Vinna=true;
                Console.WriteLine("Rätt");
            }
                else if()

            }
        }
    }
}

