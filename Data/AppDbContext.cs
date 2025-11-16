using EstudosApiRest.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudosApiRest.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<PersonModel> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.sqlite");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
