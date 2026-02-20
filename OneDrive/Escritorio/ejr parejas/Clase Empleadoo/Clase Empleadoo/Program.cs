using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Empleadoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 miEmpleado = new Class1("Carlos López", "Ingeniero de Software", 2500.00, "Desarrollo", new DateTime(2018, 5, 10));

            miEmpleado.MostrarInformacion();

            Console.WriteLine($"Años trabajados: {miEmpleado.CalcularAntiguedad()} años");

            miEmpleado.ActualizarSalario(3000.00);

            miEmpleado.CambiarDepartamento("Innovación");

        }
    }
}
