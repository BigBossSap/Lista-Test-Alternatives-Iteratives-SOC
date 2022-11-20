using System;

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*11.Escriure un programa en ‘C’ que ens mostri els N primers termes de la sèrie
de Fibonacci, on N és un natural entrat pel teclat. (1, 1, 2, 3, 5, 8, 13, ... ) */

            int i = 1, j = 0, seguent, primer = 0, segon = 1, n;
            string secuencia="0 1";    
            Console.WriteLine("n: ");
            n = int.Parse(Console.ReadLine());




            for (i = 0; i <= n; i++)
            {


                seguent = primer + segon;
                primer = segon;
                segon = seguent;
                secuencia = secuencia + " "  + seguent;
                
                
                
            }

            Console.WriteLine(secuencia);

            


        }
    }
}
