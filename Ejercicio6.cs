using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic2
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;
            DateTime hora = DateTime.Now;
            Console.WriteLine("Hoy es {0} de {1} de {2} y son las {3}", fecha.Day, fecha.Month, fecha.Year, hora.ToString("HH:mm"));
            Console.ReadKey();
        }
    }
}
