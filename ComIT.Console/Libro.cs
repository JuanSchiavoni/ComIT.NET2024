using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComIT.Console
{
    public class Libro
    {
        public string titulo;
        public string autor;
        public int cantidad;
        public int cantidadPrestados;


        public Libro() 
        {
            titulo = "Desconocido";
            autor = "Desconocido";
            cantidad = 0;
            cantidadPrestados = 0;
        }

        public Libro(string t, string a, int c, int cp)
        {
            titulo = t;
            autor = a;
            cantidad = c;
            cantidadPrestados = cp; 
        }

        public bool Prestar()
        {
            if (cantidadPrestados >= cantidad) 
            {
                System.Console.WriteLine($"Ya prestamos todos los ejemplares de {titulo}");
                return false;
            }else
            {
                cantidadPrestados++;
                System.Console.WriteLine($"Ejemplar de {titulo} prestado con éxito. Disponibles {cantidad-cantidadPrestados}");
                return true;    
            }
        }

        public bool Devolver()
        {
            if(cantidadPrestados > 0)
            {
                cantidadPrestados--;
                System.Console.WriteLine($"Ejemplar de {titulo} devuelto con éito");
                return true;
            }else
            {
                System.Console.WriteLine($"No hay ejemplares de {titulo} pretados");
                return false;
            }
        }

        public void MostrarLibros()
        {
            System.Console.WriteLine(titulo);
            System.Console.WriteLine(autor);
            System.Console.WriteLine(cantidad);
            System.Console.WriteLine(cantidadPrestados);
        }
    }
}
