using System;

namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*9. Escriure un programa en ‘C’ que ens proporcioni la següent sortida:
   1 = 1
   1 + 2 = 3
   1 + 2 + 3 = 6 */

            //Teoria, anar treient els nombres perfectes i colocar els seus divisors  a la suma.

            
            int num1, sumadivisors = 0, i = 1;

            Console.WriteLine("num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            while (i <= num1)
            {
                if (num1 % i == 0)
                    sumadivisors += i;
                i++;
                Console.WriteLine(sumadivisors);

            }

            if (sumadivisors == num1)
                Console.WriteLine("Es perfecte");
            else
                Console.WriteLine("No es perfecte");









        }
    }
}
