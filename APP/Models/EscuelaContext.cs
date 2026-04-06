using Microsoft.EntityFrameworkCore;

namespace APP.Models
{
    public class EscuelaContext : DbContext
    {
        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options)
        {

        }

        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
