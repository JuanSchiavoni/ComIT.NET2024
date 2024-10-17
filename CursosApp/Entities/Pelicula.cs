namespace ComIT.CursosApp.Entities
{
    public class Pelicula
    {
        public string name = string.Empty;
        public int calif = 0;

        public Pelicula (string name, int calif)
        {
            this.name = name;
            this.calif = calif;
        }
    }
}
