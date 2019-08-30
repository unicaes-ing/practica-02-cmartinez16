using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic2
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            double total = 0, precio;
            DateTime inicio;
            DateTime final;
            Console.WriteLine("Alquiler de autos");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Ingrese la fecha de alquiler del auto");
            inicio = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de devolucion del auto");
            final = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese el precio de alquiler por dia");
            precio = Convert.ToDouble(Console.ReadLine());
            total = precio * final.Subtract(inicio).Days;
            Console.WriteLine("------------------------------");
            Console.Write("Fecha de alquiler: ");
            Console.WriteLine(inicio.ToString("dd:MM:yyyy"));
            Console.Write("Fecha de devolucion: ");
            Console.WriteLine(final.ToString("dd:MM:yyyy"));
            Console.Write("Dias de alquiler: ");
            Console.WriteLine(final.Subtract(inicio).Days);
            Console.WriteLine("El total del alquiler es de: ${0}", total);
            Console.ReadKey();
        }
    }
}
