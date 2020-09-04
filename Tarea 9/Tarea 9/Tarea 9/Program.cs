using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            
            Console.WriteLine("Introduce un número:");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce otro número:");
            numero2 = Convert.ToInt32(Console.ReadLine());

            int producto = numero1 * numero2;
            
            Console.WriteLine("El producto entre {0} y {1} es igual a {2}",
                numero1,numero2,producto);
            Console.ReadLine();
        }
    }
}
