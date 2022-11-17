using System;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3. Donats dos números naturals (no negatius) entrats pel teclat que han de ser
   diferents de zero (en cas de que algun dels números, o tots dos siguin zero,
   cal que tregui un missatge d’error per pantalla), dir si són divisors entre ells*/

            int num1, num2;

            Console.Write("Num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Num2: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1==0 || num2 == 0)
                Console.WriteLine("Error, els numeros introduits no poden ser 0");


            if(num1%num2 == 0)
                Console.WriteLine($"{num2} es divisor de {num1}");
            else if (num2%num1 == 0)
                Console.WriteLine($"{num1} es divisor de {num2}");
            else
                Console.WriteLine("No son divisors");




        }
    }
}
