using Microsoft.EntityFrameworkCore;
using MVCBackend.Models;

namespace MVCBackend.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { 
        }

        public DbSet<Usuario> Tarea { get; set; }
    }
}
