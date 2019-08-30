using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic2
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            string numero;
            DateTime HoraI;
            DateTime HoraF;
            Double total, precioM;
            Console.WriteLine("Servicio de llamadas telefonicas");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Por favor ingrese la hora de inicio de la llamada: ");
            HoraI = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Por favor ingrese la hora de finalizacion de la llamada: ");
            HoraF = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese el precio por minuto de la llamada");
            precioM = Convert.ToDouble(Console.ReadLine());
            total = precioM * HoraF.Subtract(HoraI).TotalMinutes;
            Console.WriteLine("Datos de la llamada");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hora de inicio: {0}", HoraI.ToString("HH:mm"));
            Console.WriteLine("Hora de finalizacion: {0}", HoraF.ToString("HH:mm"));
            Console.WriteLine("Minutos transcurridos: {0}", HoraF.Subtract(HoraI).TotalMinutes);
            Console.WriteLine("Precio por minuto: {0}", precioM);
            Console.WriteLine("");
            Console.WriteLine("Total a pagar: {0}", total.ToString("C2"));
            Console.ReadKey();
        }
    }
}
