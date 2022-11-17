using System;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5. Donat un número enter que designa un període de temps expressat en
   segons, determinar un programa en que doni l’equivalent en dies, hores,
   minuts i segons. */

            int segonsInput, dies, hores, minuts, segons;

            Console.WriteLine("Segons: ");
            segonsInput = int.Parse(Console.ReadLine());

            minuts = segonsInput / 60;
            hores = segonsInput / 3600;
            dies = segonsInput / 86400;
            segons = segonsInput % 60;

           

            if (minuts >= 60)
            {
                hores = minuts / 60;
                minuts = minuts % 60;
            }

            if (  hores >= 24) { 
            
                dies = hores/24;
                hores = hores % 24;
            }

            Console.WriteLine($"{segonsInput} son: {dies} dies, {hores} hores, {minuts} minuts , {segons} segons");

            





        }
    }
}
