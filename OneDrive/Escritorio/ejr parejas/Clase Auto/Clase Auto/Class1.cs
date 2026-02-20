using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Auto
{
    internal class Class1
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public int VelocidadActual { get; private set; }
        public string Color { get; set; }
        public string Combustible { get; set; }

        // Constructor
        public Class1(string marca, string modelo, int año, string color, string combustible)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            VelocidadActual = 0;
            Color = color;
            Combustible = combustible;
        }

        // Métodos
        public void Acelerar(int incremento)
        {
            VelocidadActual += incremento;
            Console.WriteLine($"El auto ha acelerado a {VelocidadActual} km/h.");
        }

        public void Frenar(int decremento)
        {
            VelocidadActual -= decremento;
            if (VelocidadActual < 0)
            {
                VelocidadActual = 0;
            }
            Console.WriteLine($"El auto ha frenado a {VelocidadActual} km/h.");
        }

        public void MostrarEstado()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Año}");
            Console.WriteLine($"Velocidad Actual: {VelocidadActual} km/h");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Combustible: {Combustible}");
        }

        public void Pintar(string nuevoColor)
        {
            Color = nuevoColor;
            Console.WriteLine($"El auto ha sido pintado de color {Color}.");
        }

        public void Repostar(string tipoCombustible, int litros)
        {
            Combustible = tipoCombustible;
            Console.WriteLine($"Se han repostado {litros} litros de {Combustible}.");
        }


    }
}
