using System;

namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*12.Fer un programa que permeti triar entre calcular la longitud d’una
   circumferència, l’àrea d’un cercle o el volum d’una esfera donat un Radi
   entrat pel teclat. (Longitud = 2 * π * Radi; Àrea = π * Radi * Radi; Volum = 4/3
   * π * Radi * Radi * Radi) */


            double radi, decisio, longitud, area, volum, pi= 3.1415926535897931;

            Console.WriteLine("Que vols fer?");
            Console.WriteLine("Introdueix:");  
            Console.WriteLine("1 per longitud");  
            Console.WriteLine("2 per area");   
            Console.WriteLine("3 per volum");  
            decisio = double.Parse(Console.ReadLine());
            Console.WriteLine("Introdueix el radi: ");
            radi = double.Parse(Console.ReadLine());
            
            if (decisio == 1)
            {
                longitud = 2 * pi * radi;
                Console.WriteLine($"La longitud de la circumferencia es {longitud}");

            }

            else if (decisio == 2)
            {
                area = pi * radi * radi;
                Console.WriteLine($"L'àera de la circumferencia es {area}");
            }

            else
            {
                volum = 4 * pi * radi * radi * radi / 3;
                Console.WriteLine($"El volum de la circumferencia es {volum}");

            }







        }
    }
}
