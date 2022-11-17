using System;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. Dissenyar un programa en ‘C’ que ens informi si un any qualsevol és de
   traspàs. (Són de traspàs tots els anys múltiples de quatre, que no ho son de
   cent, a no ser, que siguin múltiples de quatre-cents, que llavors sí que són
   de traspàs) */


            double any;
            Console.WriteLine("any: ");
            any = double.Parse(Console.ReadLine());

            if (any<=0)
                Console.WriteLine("any invalid");

            else if (any%400==0)
                Console.WriteLine($"{any} es un any de trapas");
            else if (any%4==0 && any%100!=0)
                Console.WriteLine($"{any} es un any de trapas");
            else
                Console.WriteLine($"{any}  no es un any de trapas");


        }
    }
}
