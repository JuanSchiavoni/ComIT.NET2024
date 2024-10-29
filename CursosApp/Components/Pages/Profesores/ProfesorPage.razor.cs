using ComIT.Comunes.Entities;



namespace CursosApp.Components.Pages.Profesores
{
    public partial class ProfesorPage
    {
        private string error = "";
        private bool estamosModificando = false;
        private Profesor? profesorModificando;

        private long dni = 0;
        private string nombre = "";
        private string apellido = "";
        private DateOnly? fechaNac;
        private int añosExp;
        private string materia = "";
        private List<Profesor> ProfesoresList = new();

        private void NuevoProfesor()
        {

        }

        private void Agregar()
        {
            if (dni == 0 || nombre == "" || apellido == "" || fechaNac == null || materia == "")
            {
                error = "No se ingresaron todos los datos";
            }
            else
            {
                ProfesoresList.Add(new Profesor(dni, nombre, apellido, (DateOnly)fechaNac, añosExp, materia));

                dni = 0;
                nombre = "";
                apellido = "";
                fechaNac = null;
                añosExp = 0;
                materia = "";

                error = "";
            }
        }

        private void Modificar(Profesor profeModificar)
        {
            estamosModificando = true;
            profesorModificando = profeModificar;

            dni = profeModificar.DNI;
            nombre = profeModificar.Nombre;
            apellido = profeModificar.Apellido;
            fechaNac = profeModificar.FechaNac;
            añosExp = profeModificar.AñosExp;
            materia = profeModificar.Materia;
        }

        private void GuardarCambios()
        {
            if (dni == 0 || nombre == "" || apellido == "" || fechaNac == null || materia == "")
            {
                error = "No se ingresaron todos los datos";
            }
            else
            {
                profesorModificando.DNI = dni;
                profesorModificando.Nombre = nombre;
                profesorModificando.Apellido = apellido;
                profesorModificando.FechaNac = (DateOnly)fechaNac;
                profesorModificando.AñosExp = añosExp;
                profesorModificando.Materia = materia;

                dni = 0;
                nombre = "";
                apellido = "";
                fechaNac = null;
                añosExp = 0;
                materia = "";

                estamosModificando = false;
                profesorModificando = null;
            }
        }

        private void Eliminar(Profesor profeEliminar)
        {
            ProfesoresList.Remove(profeEliminar);
        }
        
    }
}
