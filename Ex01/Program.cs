using System;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Escriure un programa que demani tres números entrats pel teclat, i ens digui
   quin és el més gran de tots tres. Cal contemplar la possibilitat de que dos
   dels tres números, o tots tres siguin iguals. 
   */
            int num1, num2, num3;

            Console.Write("Num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Num2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Num3: ");
            num3 = int.Parse(Console.ReadLine());


            if (num1 >= num2 && num1 >= num3)
            {

                Console.WriteLine(num1);
                if (num1 == num2 && num1 == num3)
                        Console.WriteLine("Pero els tres numeros son iguals");

                else if (num1==num2)
                    Console.WriteLine($"Pero {num1} i {num2} son iguals");
                else if (num1==num3)
                    Console.WriteLine($"Pero {num1} i {num2} son iguals");
                
            }


            else if (num2 >= num3 && num2 >= num1)
            {
                Console.WriteLine(num2);
                if (num2 == num1 && num2 == num3)
                    Console.WriteLine("Pero els tres numeros son iguals");
                else if (num2 == num1)
                    Console.WriteLine($"Pero {num2} i {num1} son iguals");
                else if (num2 == num3)
                    Console.WriteLine($"Pero {num1} i {num3} son iguals");
                


            }
            else if (num3 >= num2 && num3 >= num1)
            {
                Console.WriteLine(num3);
                if (num3 == num1 && num3 == num2)
                        Console.WriteLine("Pero els tres numeros son iguals");

                else if (num3 == num1)
                    Console.WriteLine($"Pero {num3} i {num1} son iguals");
                else if (num3 == num2)
                    Console.WriteLine($"Pero {num2} i {num3} son iguals");
                else if (num3 == num1 && num3 == num2)
                    Console.WriteLine("Pero els tres numeros son iguals");


            }
            



        }
    }
}
