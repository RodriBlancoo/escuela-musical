using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _4.Clase_Producto
{
    internal class ClaseProducto
    {
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public string CodigoBarras { get; set; }
        public string Categoria { get; set; }

        // Constructor
        public ClaseProducto(string nombre, decimal precioUnitario, int cantidad, string codigoBarras, string categoria)
        {
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
            Cantidad = cantidad;
            CodigoBarras = codigoBarras;
            Categoria = categoria;
        }

        // Métodos
        public decimal CalcularTotal()
        {
            return PrecioUnitario * Cantidad;
        }

        public void MostrarProducto()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio Unitario: {PrecioUnitario:C}");
            Console.WriteLine($"Cantidad: {Cantidad}");
            Console.WriteLine($"Código de Barras: {CodigoBarras}");
            Console.WriteLine($"Categoría: {Categoria}");
            Console.WriteLine($"Total: {CalcularTotal():C}");
        }

        public void AplicarDescuento(float porcentaje)
        {
            PrecioUnitario -= PrecioUnitario * (porcentaje / 100);
        }

        public void ActualizarCantidad(int nuevaCantidad)
        {
            Cantidad = nuevaCantidad;
        }

    }
}
