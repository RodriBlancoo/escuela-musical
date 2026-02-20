using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Rectángulo
{
    internal class Class1
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public string Color { get; set; }
        public string Nombre { get; set; }

        public Class1(double baseRectangulo, double alturaRectangulo, string color, string nombre)
        {
            Base = baseRectangulo;
            Altura = alturaRectangulo;
            Color = color;
            Nombre = nombre;
        }
        public double CalcularArea()
        {
            return Base * Altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }

        public void CambiarTamaño(double nuevaBase, double nuevaAltura)
        {
            Base = nuevaBase;
            Altura = nuevaAltura;
        }

        public void MostrarDescripcion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Base: {Base}");
            Console.WriteLine($"Altura: {Altura}");
            Console.WriteLine($"Área: {CalcularArea()}");
            Console.WriteLine($"Perímetro: {CalcularPerimetro()}");
        }


    }
}
