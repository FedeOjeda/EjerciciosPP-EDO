using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            do
            {
                Console.WriteLine(contador);
                contador = contador + 1;
            }

            while (contador <= 10);

            Console.ReadLine();

            
        }
    }
}
