using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un número:");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("El número {0} es par.", numero);

            Console.ReadLine();

        }
    }
}
