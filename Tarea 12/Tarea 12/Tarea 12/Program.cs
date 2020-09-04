using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_12
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

            
            if (n2 != 0)
                Console.WriteLine(n1/n2);
            else
                Console.WriteLine("Error: No se puede dividir entre cero.");

            Console.ReadLine();
        }
    }
    }

