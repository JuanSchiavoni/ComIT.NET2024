using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComIT.Comunes.Entities
{
    public class Alumno : Persona
    {
        public bool Trabajo = true;

        public Alumno(long dni, string nombre, string apellido, DateOnly fechaNac, bool trabajo) 
            : base(dni, nombre, apellido, fechaNac)
        {
            Trabajo = trabajo;
        }

        public override string Saludo()
        {
            return "Buenos dias Profesor";
        }
    }
}
