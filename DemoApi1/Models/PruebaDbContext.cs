using Microsoft.EntityFrameworkCore;

namespace DemoApi1.Models
{
    public class PruebaDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public PruebaDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
