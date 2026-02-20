using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Animal
{
    internal class Class1
    {
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public int Edad { get; set; }
        public string Color { get; set; }
        public double Peso { get; set; }

      
        public Class1(string nombre, string especie, int edad, string color, double peso)
        {
            Nombre = nombre;
            Especie = especie;
            Edad = edad;
            Color = color;
            Peso = peso;
        }

      
        public void EmitirSonido()
        {
            Console.WriteLine($"{Nombre} hace un sonido.");
        }

    
        public void MostrarDescripcion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Especie: {Especie}");
            Console.WriteLine($"Edad: {Edad} años");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Peso: {Peso} kg");
        }

        
        public void Alimentar(double gramosComida)
        {
            Peso += gramosComida / 1000; 
            Console.WriteLine($"{Nombre} ha sido alimentado y ahora pesa {Peso} kg.");
        }

        
        public void CambiarEspecie(string nuevaEspecie)
        {
            Especie = nuevaEspecie;
            Console.WriteLine($"{Nombre} ahora es de la especie {Especie}.");
        }

    }
}
