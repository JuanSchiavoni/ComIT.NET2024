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

        private ProfesorModal modal = default;

        private void NuevoProfesor()
        {
            profesorModificando = new Profesor();
            modal.Open();
        }

        private void Guardar()
        {
            if (profesorModificando.DNI == 0 || profesorModificando.Nombre == "" || profesorModificando.Apellido == "" || profesorModificando.FechaNac == null || profesorModificando.Materia == "")
            {
                error = "No se ingresaron todos los datos";
            }
            else
            {
                if (!estamosModificando)
                {
                    ProfesoresList.Add(profesorModificando);
                }
                else
                {
                    estamosModificando = false;
                }

                profesorModificando = null;
                error = "";
                modal.Close();
            }
        }

        private void Modificar(Profesor profeModificar)
        {
            estamosModificando = true;
            profesorModificando = profeModificar;

            modal.Open();
        }

        private void Eliminar(Profesor profeEliminar)
        {
            ProfesoresList.Remove(profeEliminar);
        }
        
    }
}
