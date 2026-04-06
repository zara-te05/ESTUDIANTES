using Microsoft.EntityFrameworkCore;

namespace PRUEBA.Models
{
    public class StudentsDbContext : DbContext
    {
        public DbSet<Student> students { get; set; }

        public StudentsDbContext(DbContextOptions<StudentsDbContext> options)
            : base(options)
        {

        }
    }
}
