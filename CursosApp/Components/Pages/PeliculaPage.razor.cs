using ComIT.CursosApp.Entities;

namespace CursosApp.Components.Pages
{
    public partial class PeliculaPage
    {
        private string error = "";
        private bool estamosModificando = false;
        private Pelicula? pelimodi;

        private string nombrePeli = "";
        private int calificacion = 0;

        private List<Pelicula> PeliculasList = new();

        private void AgregarPeli()
        {
            if (nombrePeli == "" || calificacion == null)
            {
                error = "No se cargaron todos los datos";
            }
            else
            {
                PeliculasList.Add(new Pelicula(nombrePeli, calificacion));

                nombrePeli = "";
                calificacion = 0;
            }
        }

        private void Modificar(Pelicula pelimodificar)
        {
            estamosModificando = true;
            pelimodi = pelimodificar;

            nombrePeli = pelimodificar.name;
            calificacion = pelimodificar.calif;
        }

        private void GuardarCambios()
        {
            if (nombrePeli == "" || calificacion == null)
            {
                error = "No se cargaron todos los datos";
            }
            else
            {
                pelimodi.name = nombrePeli;
                pelimodi.calif = calificacion;

                nombrePeli = "";
                calificacion = 0;

                estamosModificando = false;
                pelimodi = null;
            }
        }

        private void Eliminar(Pelicula peliEliminiar)
        {
            PeliculasList.Remove(peliEliminiar);
        }

    }
}
