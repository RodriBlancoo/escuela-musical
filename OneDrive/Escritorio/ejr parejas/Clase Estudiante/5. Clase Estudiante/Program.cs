using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Clase_Estudiante
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Clase_Estudiante estudiante = new Clase_Estudiante("Carlos López", "Matemáticas", 75.5, "E12345", "carlos.lopez@example.com");
        estudiante.MostrarDatos();
        Console.WriteLine("\nVerificando resultado...");
        estudiante.MostrarResultado();
        Console.WriteLine("\nActualizando nota a 55.0...");
        estudiante.ActualizarNotaFinal(55.0);
        estudiante.MostrarResultado();
        Console.WriteLine("\nEnviando correo de notificación...");
        estudiante.EnviarCorreo("Estimado estudiante, su nota ha sido actualizada. Consulte la plataforma académica para más detalles.");
        }
    }
}
