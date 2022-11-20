using System;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, a, b, i = 1, residu=0;

            Console.WriteLine("num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("num2: ");
            num2 = int.Parse(Console.ReadLine());

            a = Math.Max(num1, num2);
            b = Math.Min(num1, num2);

            while (b != 0)
            {
                residu = a % b;
                a = b;
                b = residu;
            }

            Console.WriteLine(a);


        }
    }
}
