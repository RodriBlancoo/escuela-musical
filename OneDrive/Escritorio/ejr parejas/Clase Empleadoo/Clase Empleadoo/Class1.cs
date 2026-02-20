using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Empleadoo
{
    internal class Class1
    {
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public string Departamento { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Class1(string nombre, string cargo, double salario, string departamento, DateTime fechaIngreso)
        {
            Nombre = nombre;
            Cargo = cargo;
            Salario = salario;
            Departamento = departamento;
            FechaIngreso = fechaIngreso;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salario: ${Salario}");
            Console.WriteLine($"Departamento: {Departamento}");
            Console.WriteLine($"Fecha de Ingreso: {FechaIngreso.ToShortDateString()}");
        }

        
        public int CalcularAntiguedad()
        {
            return DateTime.Now.Year - FechaIngreso.Year;
        }

        public void ActualizarSalario(double nuevoSalario)
        {
            Salario = nuevoSalario;
            Console.WriteLine($"El nuevo salario de {Nombre} es ${Salario}");
        }

        public void CambiarDepartamento(string nuevoDepartamento)
        {
            Departamento = nuevoDepartamento;
            Console.WriteLine($"{Nombre} ahora trabaja en el departamento de {Departamento}");
        }

    }
}
