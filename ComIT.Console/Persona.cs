using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComIT.Console
{
    public class Persona
    {
        public long DNI = 0;
        public string Nombre = string.Empty;
        public string Apellido = string.Empty;
        public DateOnly FechaNac = new();

        public Persona(long dni, string nombre, string apellido, DateOnly fechaNac)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechaNac;
        }
    }
}
