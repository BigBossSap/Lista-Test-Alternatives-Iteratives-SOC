using System;

namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*13.Escriure un programa en ‘C’ que quan se li entra un lletra minúscula,
   ensenya la seva majúscula corresponent. (Només si se li entra una lletra
   minúscula) */


            char lletra;
            int lletraMajuscula;

            Console.WriteLine("lletra: ");
            lletra = Convert.ToChar(Console.ReadLine());

            while (lletra > 122 || lletra < 97)
            {
                Console.WriteLine("No es una lletra. Torna a provar: ");
                lletra=Convert.ToChar(Console.ReadLine());  
            }

            lletraMajuscula = lletra - 32;
            Console.WriteLine($"La lletra {lletra} en majuscula es {(char)lletraMajuscula}");
            








        }
    }
}
