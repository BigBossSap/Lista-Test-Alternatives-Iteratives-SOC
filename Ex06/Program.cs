using System;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6. Donada una expressió horària en el format hores, minuts, segons (entrar 3
   números i validar que estiguin entre 0 i 59), afegir-hi un segon i retornar el
   resultat en el mateix format. */

            int data,hores, minuts, segons, dataFinal;

            Console.WriteLine("Intordueix una hora en el seguent format: hhmmss: ");
            data= int.Parse(Console.ReadLine());

            hores = data / 10000;
            minuts = data / 100 % 100;
            segons = data % 100;

            while (minuts > 59 || segons > 59)
            {
                Console.WriteLine("data incorrecta");
                Console.WriteLine("tornaa probar: ");
                data= int.Parse(Console.ReadLine());
                hores = data / 10000;
                minuts = data / 100 % 100;
                segons = data % 100;

            }

            segons++;

            if (segons > 59)
            {
                minuts += 1;
                segons = segons % 60;
            }
            if (minuts>59)
            {
                hores += 1;
                minuts %= 60;
            }

            dataFinal = segons + minuts * 100 + hores * 10000;

            Console.WriteLine($"{ hores}, { minuts}, { segons}, Data Final: {dataFinal}");


        }
    }
}
