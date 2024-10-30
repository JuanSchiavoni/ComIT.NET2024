using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComIT.Comunes.Entities
{
    public abstract class Persona
    {
        public long DNI = 0;
        public string Nombre = string.Empty;
        public string Apellido = string.Empty;
        public DateOnly FechaNac = new();


        public string NombreCompleto
        {
            get
            {
                //System.Console.WriteLine("Me estan pidiendo un valor");
                return ($"{Nombre} {Apellido}");
            }
            set
            {
                //System.Console.WriteLine("Me guardaron un valor");
            }
        }

        public Persona() { }

        public Persona(long dni, string nombre, string apellido, DateOnly fechaNac)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechaNac;
        }

        public virtual string DevolverNombreCompleto()
        {
            return ($"{Nombre} {Apellido}");
        }

        public abstract string Saludo();
    }
}
