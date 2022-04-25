using Microsoft.EntityFrameworkCore;
using Vet_App.Models;

namespace Vet_App.Context
{
    public class AnimalDatabaseContext : DbContext
    {
        public AnimalDatabaseContext(DbContextOptions<AnimalDatabaseContext> options) : base(options) { }

        public DbSet<Animal> Animals { get; set; }
    }
}
