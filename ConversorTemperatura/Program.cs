using System;

namespace Temperatura 
{
    class Program
    {
        static void Main(string[] args)
        {
            double t1, t2, t3;

            Console.WriteLine("Conversor de temperaturas");

            Console.WriteLine("Digite o valor da temperatura em celcius: ");
            t1 = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");

            t2 = (t1 * 9 / 5) + 32;
            t3 = (t1 + 273.15);

            Console.WriteLine(t1 + " graus celcius para fareheint é " + t2);
            Console.WriteLine(t1 + " graus celcius para kelvin é " + t3);
            Console.ReadKey();
        }
    }
}