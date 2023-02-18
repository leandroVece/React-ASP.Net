using cadeteria.Models;
using Microsoft.EntityFrameworkCore;

namespace cadeteria;

public class DataContext : DbContext
{
    public DbSet<Cadetes> Cadetes { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        List<Cadetes> listCadete = new List<Cadetes>();
        listCadete.Add(new Cadetes() { Id = 1, Nombre = "Jaun Castellanos", Direccion = "Entre rios", Telefono = "231321231" });
        listCadete.Add(new Cadetes() { Id = 2, Nombre = "Ana Hume", Direccion = "independencia", Telefono = "231321231" });


        modelBuilder.Entity<Cadetes>(Cadete =>
        {
            Cadete.ToTable("Cadete");
            Cadete.HasKey(p => p.Id);

            Cadete.Property(p => p.Nombre).IsRequired().HasMaxLength(20);
            Cadete.Property(p => p.Direccion).IsRequired();
            Cadete.Property(p => p.Telefono).IsRequired();
            //Cadete.Ignore(p => p.Listpedido);

            Cadete.HasData(listCadete);
        });

    }


}