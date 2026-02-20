using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Auto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 auto1 = new Class1("Toyota", "Corolla", 2022, "Blanco", "Gasolina");

        Console.WriteLine("Estado inicial del auto:");
        auto1.MostrarEstado();

        auto1.Acelerar(50); 
        auto1.Frenar(20);
        auto1.Pintar("Rojo");
        auto1.Repostar("Gasolina", 40);

        Console.WriteLine("\nEstado actualizado del auto:");
        auto1.MostrarEstado();

        }
    }
}
