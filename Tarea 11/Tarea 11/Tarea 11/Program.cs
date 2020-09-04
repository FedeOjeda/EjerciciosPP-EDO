using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Ingrese un número:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro número:");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
                Console.WriteLine("{0} es más grande que {1}.",n1, n2);
            else
                Console.WriteLine("{0} es más grande que {1}.",n2, n1);

            Console.ReadLine();

        }
    }
}
