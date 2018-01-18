using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Ingrese el numero: ");
            n = Convert.ToInt32(Console.ReadLine());
            int e;
            double d;
            e = n / 2;
            d = n / 2;
            if(d - e == 0)
            {
                Console.WriteLine("El numero: {0}  es par",n);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El numero:  {0}  es impar",n);
                Console.ReadKey();
            }

        }
    }
}
