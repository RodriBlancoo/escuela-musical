using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPersona
{
    internal class Class1
    {
        private string nombre;
        private double edad;
        private string ciudad;
        private string genero;
        private string ocupacion;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Edad { get => edad; set => edad = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Ocupacion { get => ocupacion; set => ocupacion = value; }

        public Class1()
        {

        }

        public Class1(string nombre, double edad, string ciudad, string genero, string ocupacion)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.ciudad = ciudad;
            this.genero = genero;
            this.ocupacion = ocupacion;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre:{0}\tEdad:{1}\tCiudad:{2}\t Genero:{3}\t Ocupacion:{4}\t", nombre, edad, ciudad, genero, ocupacion);

        }
        public void EsMayorDeEdad()
        {
            if (edad == 18 && edad > 18)
            {
                Console.Write("True");

            }
            else
            {
                Console.WriteLine("Eres menor de edad");
                return;
            }
        }
        public void CambiarCiudad(string nuevaCiudad)
        {
            Ciudad = nuevaCiudad;
        }

        public void ActualizarOcupacion(string nuevaOcupacion)
        {
            Ocupacion = nuevaOcupacion;
        }

    }
}
