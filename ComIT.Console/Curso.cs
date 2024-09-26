using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComIT.Console
{
    public class Curso
    {
        public string Nombre = "";
        public int CantMaxAlumnos = 0;
        public Profesor Profesor;
        public Alumno[] Alumnos;

        public Curso(string nombreCurso, int cantMax, Profesor profe)
        {
            Nombre = nombreCurso;
            CantMaxAlumnos = cantMax;
            Profesor = profe;
            //Crea una array del tamaño de la cantidad maxima de alumnos
            Alumnos = new Alumno[CantMaxAlumnos];
        }
    }
}
