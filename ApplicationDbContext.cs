using Microsoft.EntityFrameworkCore;
using TransitoCapsuleCorp.Models;

namespace TransitoCapsuleCorp;

public class ApplicationDbContext : DbContext
{
    public DbSet<Multa> Multa { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Multa>(multa =>
        {
            multa.ToTable("Multa");
            multa.HasKey(p => p.MultaId);
            multa.Property(p => p.LocalizacionX).IsRequired();
            multa.Property(p => p.LocalizacionY).IsRequired();
            multa.Property(p => p.Imagen).IsRequired().HasMaxLength(500);
            multa.Property(p => p.AlturaVuelo).IsRequired();
            multa.Property(p => p.Velocidad).IsRequired();
            multa.Property(p => p.Matricula).IsRequired().HasMaxLength(6);
            multa.Property(p => p.Ciudad).IsRequired().HasMaxLength(100);
            multa.Property(p => p.TipoAuto).IsRequired();
            multa.Property(p => p.Valida).IsRequired();
            multa.Property(p => p.Distancia);
        });
    }
}
