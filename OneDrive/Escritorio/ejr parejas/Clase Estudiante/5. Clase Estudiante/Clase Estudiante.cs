using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Clase_Estudiante
{
    internal class Clase_Estudiante
    {
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public double NotaFinal { get; set; }
        public string ID { get; set; }
        public string CorreoElectronico { get; set; }

        // Constructor
        public Clase_Estudiante(string nombre, string materia, double notaFinal, string id, string correoElectronico)
        {
            Nombre = nombre;
            Materia = materia;
            NotaFinal = notaFinal;
            ID = id;
            CorreoElectronico = correoElectronico;
        }

        // Métodos
        public void MostrarResultado()
        {
            if (NotaFinal >= 60)
            {
                Console.WriteLine($"{Nombre} ha aprobado la materia {Materia} con una nota de {NotaFinal}.");
            }
            else
            {
                Console.WriteLine($"{Nombre} ha reprobado la materia {Materia} con una nota de {NotaFinal}.");
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Materia: {Materia}");
            Console.WriteLine($"Nota Final: {NotaFinal}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Correo Electrónico: {CorreoElectronico}");
        }

        public void ActualizarNotaFinal(double nuevaNota)
        {
            NotaFinal = nuevaNota;
            Console.WriteLine($"La nueva nota de {Nombre} en {Materia} es {NotaFinal}.");
        }

        public void EnviarCorreo(string mensaje)
        {
            Console.WriteLine($"Simulando el envío de correo a {CorreoElectronico}...");
            Console.WriteLine($"Mensaje: {mensaje}");
        }

    }
}
