using CursosApp.Model;
using Microsoft.EntityFrameworkCore;

namespace CursosApp.Context
{
    public class CursosAppContext : DbContext
    {
        public CursosAppContext(DbContextOptions<CursosAppContext> options) : base (options)
        {
        }
        public DbSet<Profesor> Profesores {  get; set; }

        public DbSet<Curso> Cursos { get; set; }
    }
}
