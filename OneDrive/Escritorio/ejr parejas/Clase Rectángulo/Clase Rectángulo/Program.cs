using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Rectángulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 rectangulo1 = new Class1(10, 5, "Rojo", "Rectángulo A");

            Console.WriteLine("Descripción Inicial:");
            rectangulo1.MostrarDescripcion();

            rectangulo1.CambiarTamaño(15, 7);

            Console.WriteLine("\nDescripción Actualizada:");
            rectangulo1.MostrarDescripcion();

        }
    }
}
