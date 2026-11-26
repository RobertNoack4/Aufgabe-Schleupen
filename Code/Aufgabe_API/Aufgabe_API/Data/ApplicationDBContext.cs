using Aufgabe_API.Model;
using Microsoft.EntityFrameworkCore;

namespace Aufgabe_API.Data
{
    public class ApplicationDBContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Person> Personen { get; set; }
        public DbSet<Anschrift> Anschrift { get; set; }
        public DbSet<Telefonverbindung> Telefonverbindung { get; set; }
    }
}
