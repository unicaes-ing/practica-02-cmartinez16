using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic2
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            string nombre;
            int cantidad;
            double iva = 0.13, sub = 0, total = 0, precio = 0;
            Console.WriteLine("Ingrese el nombre del producto");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de productos que desea comprar");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del producto");
            precio = Convert.ToDouble(Console.ReadLine());
            sub = cantidad * precio;
            iva = sub * iva;
            total = sub + iva;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Su producto: {0}", nombre);
            Console.WriteLine("La cantidad de {0} es de: {1}", nombre, cantidad);
            Console.WriteLine("El subtotal es de: ${0}", sub);
            Console.WriteLine("El iva es de: ${0}", iva);
            Console.WriteLine("El valor a pagar es de: ${0}", total);
            Console.ReadKey();
        }
    }
}
