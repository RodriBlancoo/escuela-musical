using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Clase_Producto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClaseProducto producto = new ClaseProducto("Laptop", 1200.50m, 2, "123456789", "Electrónica");
            producto.MostrarProducto();
            Console.WriteLine("\nAplicando descuento del 10%...\n");
            producto.AplicarDescuento(10);
            producto.MostrarProducto();
            Console.WriteLine("\nActualizando cantidad a 5...\n");
            producto.ActualizarCantidad(5);
            producto.MostrarProducto();

        }
    }
}
