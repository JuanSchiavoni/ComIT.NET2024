using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComIT.Comunes.Entities
{
    public class Profesor : Persona
    {
        public int AñosExp = 0;
        public string Materia = "";

        public Profesor(long dni, string nombre, string apellido, DateOnly fechaNac, int añosExp, string materia) 
            : base(dni, nombre, apellido,fechaNac)
        {
            AñosExp = añosExp;
            Materia = materia;
        }

        public override string DevolverNombreCompleto()
        {
            return $"Profesor: {base.DevolverNombreCompleto()}";
        }

        public override string Saludo()
        {
            return "Buenos días alumnos";
        }
    }
}
