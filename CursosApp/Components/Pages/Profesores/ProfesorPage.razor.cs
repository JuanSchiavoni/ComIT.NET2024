using CursosApp.Context;
using CursosApp.Model;
using Microsoft.AspNetCore.Components;

namespace CursosApp.Components.Pages.Profesores
{
    public partial class ProfesorPage
    {
        [Inject]
        private CursosAppContext context { get; set; }

        private string error = "";
        private bool estamosModificando = false;

        private Profesor? profesorModificando;

        private long dni = 0;
        private string nombre = "";
        private string apellido = "";
        private DateOnly? fechaNac;
        private int añosExp;
        private string materia = "";

        private List<Profesor> ProfesoresList;

        protected override void OnInitialized()
        {
            base.OnInitialized();
            GetData();
        }

        private void GetData()
        {
            ProfesoresList = context.Profesores.ToList();
        }

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
                    context.Profesores.Add(profesorModificando);
                    context.SaveChanges();

                    GetData();
                }
                else
                {
                    context.Entry(profesorModificando).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                    GetData();
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
            context.Profesores.Remove(profeEliminar);
            context.SaveChanges();
            GetData();
        }
        
    }
}
