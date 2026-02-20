using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Círculo
{
    internal class Class1
    {
        public double Radio { get; set; }
        public string Color { get; set; }
        public string Nombre { get; set; }

     
        public Class1(double radio, string color, string nombre)
        {
            Radio = radio;
            Color = color;
            Nombre = nombre;
        }

      
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public double CalcularCircunferencia()
        {
            return 2 * Math.PI * Radio;
        }

        public void CambiarRadio(double nuevoRadio)
        {
            Radio = nuevoRadio;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Radio: {Radio}");
            Console.WriteLine($"Área: {CalcularArea()}");
            Console.WriteLine($"Circunferencia: {CalcularCircunferencia()}");
        }

    }
}
