namespace CursosApp.Model
{
    public class Curso
    {
        public Guid ID { get; set; } = Guid.NewGuid();

        public string Name { get; set; } = string.Empty;
        public int CantMax { get; set; } = 0;

    }
}
