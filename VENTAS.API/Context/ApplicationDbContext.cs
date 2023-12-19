using VENTAS.API.Models;
using Microsoft.EntityFrameworkCore;

namespace VENTAS.API.Context
{
using VENTAS.API.Models;

public class ApplicationDbContext : DbContext
{
    public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Factura> Factura { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {
    }

//public DbSet<VENTAS.API.Models.Factura> Factura { get; set; } = default!;
}
}
