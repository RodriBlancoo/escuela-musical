using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 miAnimal = new Class1("Cheester", "Perro", 5, "Blanco", 12.5);

            miAnimal.MostrarDescripcion();
            miAnimal.EmitirSonido();
            miAnimal.Alimentar(500);
            miAnimal.CambiarEspecie("Lobo");

        }
    }
}
