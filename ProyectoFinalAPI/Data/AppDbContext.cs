using Microsoft.EntityFrameworkCore;
using ProyectoFinalAPI.Models;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Empleadoo> Empleados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-GMBSO0H;Database=Minisuper;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True"); // Reemplazarr
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuider)
        {
            modelBuider.Entity<Producto>().HasData(
                new Producto()
                {
                    IdProducto = 1,
                    TipoProducto = "Pan",
                    Marca = "Bimbo",
                    Precio = 98,
                    Existencia = 500

                },
                new Producto()
                {
                    IdProducto = 2,
                    TipoProducto = "Refresco",
                    Marca = "Cocacola 3L",
                    Precio = 60,
                    Existencia = 500

                },
                new Producto()
                {
                    IdProducto = 3,
                    TipoProducto = "Leche",
                    Marca = "Eskimo",
                    Precio = 98,
                    Existencia = 500

                },
                new Producto()
                {
                    IdProducto = 4,
                    TipoProducto = "Aderezo Ranch",
                    Marca = "McCormi",
                    Precio = 72,
                    Existencia = 2000

                });
            modelBuider.Entity<Empleadoo>().HasData(
                new Empleadoo()
                {
                    Id = 1,
                    Nombre = "Mario Hernandez"
                },
                new Empleadoo()
                {
                    Id = 2,
                    Nombre = "Roberto Sanchez"
                },
                new Empleadoo()
                {
                    Id = 3,
                    Nombre = "Pepito Juarez"
                });
        }

    }
}
