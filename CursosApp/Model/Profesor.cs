namespace CursosApp.Model
{
    public class Profesor
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public long DNI { get; set; } = 0;
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public DateOnly? FechaNac {  get; set; }
        public int AñosExp { get; set; } = 0;
        public string Materia { get; set; } = string.Empty;


    }
}
