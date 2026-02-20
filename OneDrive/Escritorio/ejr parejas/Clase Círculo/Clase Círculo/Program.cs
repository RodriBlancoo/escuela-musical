using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Círculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 circulo1 = new Class1(5, "Azul", "Círculo A");

            Console.WriteLine("Datos Iniciales:");
            circulo1.MostrarDatos();

            circulo1.CambiarRadio(7);

            Console.WriteLine("\nDatos Actualizados:");
            circulo1.MostrarDatos();

        }
    }
}
