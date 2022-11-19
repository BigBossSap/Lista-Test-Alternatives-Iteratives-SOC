using System;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*8. Escriure un programa per representar les taules de multiplicar de l’1 a N, on
   N es un natural entrat pel teclat. Cada taula ha de mostrar les multiplicacions
   del 0 al 10. */


            int n, resultat=0,j=1,i=1,k=0;
            Console.WriteLine("n: ");
            n= Convert.ToInt32(Console.ReadLine());


            for (i = 1; i <= n; i++)
            {
                Console.WriteLine($"Taula de multiplicar del {i}: ");
                Console.WriteLine();

                for (j=0; j<=10; j++)
                {
                    resultat = j * i;
                    Console.WriteLine($"{j} x {i} = {resultat}");
                    


                }
                Console.WriteLine();
            }     

               


        }
    }
}
