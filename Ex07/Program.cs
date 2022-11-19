using System;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7. Trobar un programa que donat un import a pagar en Euros i una quantitat
   d’Euros amb la que es paga, ens descomposi el canvi en els diferents tipus
   de monedes (1 cèntim, 2 cèntims, 5 cèntims, 10 cèntims, 20 cèntims, 50
   cèntims, 1 euro, 2 euros), de tal manera que hi hagi el mínim número de
   monedes. */

            double paga, preu, canvi, cent1, cent2, cent5, cent10, cent20, cent50, euro, euro2, restoEuro, restoEuro2, resto1 = 0, resto2, resto3;

            Console.WriteLine("Preu: ");
            preu = double.Parse(Console.ReadLine());
            Console.WriteLine("Pagament: ");
            paga = double.Parse(Console.ReadLine());


            canvi = paga - preu;



            if (canvi >= 2)
            {

                euro2 = canvi / 2;

                canvi = canvi%2;
                Console.WriteLine($"Canvi: {euro2} monedes de 2 euros");



                if (canvi >= 1)
                {
                    euro = canvi / 1;
                    canvi = canvi - euro;
                    Console.WriteLine($"Canvi: {euro} monedes de 1 euros");
                }

                if (canvi >= 0.50)
                {
                    cent50 = canvi / 0.50;
                    canvi = canvi - (canvi % 0.50);
                    Console.WriteLine($"Canvi: {cent50} monedes de 0.50 euros");
                }


            }















        }
    }

}