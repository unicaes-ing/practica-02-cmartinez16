using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            System.Console.Write("Ingrese su nombre: ");
            nombre = System.Console.ReadLine();
            nombre = nombre.Replace("a", "#");
            nombre =   nombre.Replace("e", "%");
            nombre = nombre.Replace("i", "$");
            nombre = nombre.Replace("o", "?");
            nombre = nombre.Replace("u", "*");
            System.Console.WriteLine("El nuevo nombre generado es: {0}", nombre);
            Console.ReadKey();
        }
    }
}
