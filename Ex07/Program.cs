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

            double paga, preu, canvi,cent1,cent2,cent5,cent10,cent20,cent50,euro,euro2,restoEuro,restoEuro2;

            Console.WriteLine("Preu: ");
            preu = double.Parse(Console.ReadLine());
            Console.WriteLine("Pagament: ");
            paga = double.Parse(Console.ReadLine());


            canvi = preu - paga;

            cent1 = canvi * 100;
            cent2 = canvi * 50;
            cent5 = canvi * 20;
            cent10 = canvi * 10;
            cent20 = canvi * 5;
            cent50 = canvi * 2;
            euro = canvi;
            restoEuro = canvi * 100 % 100;
            euro2 = canvi / 2;
            restoEuro2 = canvi % 2;

            Console.WriteLine(cent1);
            Console.WriteLine(cent2);
            Console.WriteLine(cent5);
            Console.WriteLine(cent10);
            Console.WriteLine(cent20);
            Console.WriteLine(cent50);
            Console.WriteLine(euro);
            Console.WriteLine(restoEuro);
            Console.WriteLine(euro2);
            Console.WriteLine(restoEuro2);





        }
    }
}
