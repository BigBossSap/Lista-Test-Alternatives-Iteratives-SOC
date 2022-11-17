using System;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2. Escriure un programa en que calculi el valor absolut de la diferència de dos
   números entrats pel teclat. 
            */

            double num1, num2, resta, simbol=-1;
            Console.WriteLine("num1: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("num2: ");
            num2 = double.Parse(Console.ReadLine());

            resta = num1 - num2;

            if (resta < 0)
            {
                resta *= simbol;
                Console.WriteLine(resta);
            }
            else
                Console.WriteLine(resta);





        }
    }
}
