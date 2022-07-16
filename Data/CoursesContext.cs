using Microsoft.EntityFrameworkCore;
using Vet.Models;



namespace Vet.Data
{
    public class CoursesContext : DbContext
    {

        public CoursesContext(DbContextOptions<CoursesContext> options) : base(options)
        {

          
        }
        public DbSet<PetFiles> PetFile { get; set; }
        public DbSet<Types> Type { get; set; }

    }
}
