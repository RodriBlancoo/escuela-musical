using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 persona1 = new Class1("Carlos", 25, "San Salvador", "Masculino", "Ingeniero");

            Console.WriteLine("Información Inicial:");
            persona1.MostrarInformacion();

            Console.WriteLine("\nEs mayor de edad? " + (persona1.EsMayorDeEdad() ? "Sí" : "No"));

            persona1.CambiarCiudad("Santa Ana");
            persona1.ActualizarOcupacion("Desarrollador de Software");

            Console.WriteLine("\nInformación Actualizada:");
            persona1.MostrarInformacion();
        }
    }
}
