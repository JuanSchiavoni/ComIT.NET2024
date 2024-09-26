using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComIT.Console
{
    public class Profesor : Persona
    {
        public int AñosExp = 0;

        public Profesor(long dni, string nombre, string apellido, DateOnly fechaNac, int añosExp) 
            : base(dni, nombre, apellido,fechaNac)
        {
            AñosExp = añosExp;
        }
    }
}
