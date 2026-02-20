using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Libroo
{
    internal class Class1
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }
        public string Genero { get; set; }
        public string ISBN { get; set; }

        public Class1(string titulo, string autor, int numeroPaginas, string genero, string isbn)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
            Genero = genero;
            ISBN = isbn;
        }

        
        public void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Número de páginas: {NumeroPaginas}");
        }
       
            
    
    }
    }
