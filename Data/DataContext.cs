using cadeteria.Models;
using Microsoft.EntityFrameworkCore;

namespace cadeteria;

public class DataContext : DbContext
{
    public DbSet<Cadetes> Cadetes { get; set; }
    public DbSet<Clientes> Clientes { get; set; }
    // public DbSet<Pedido> Pedido { get; set; }
    // public DbSet<Usuario> Usuario { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        List<Cadetes> listCadete = new List<Cadetes>();
        listCadete.Add(new Cadetes() { Id_cadete = Guid.Parse("7b5e9399-8e95-4ae8-8745-9542a01e2cc0"), Nombre = "Jaun Castellanos", Direccion = "Entre rios", Telefono = "231321231" });
        listCadete.Add(new Cadetes() { Id_cadete = Guid.Parse("0a9fa564-0604-4dfa-88df-3636fe395651"), Nombre = "Ana Hume", Direccion = "independencia", Telefono = "231321231" });
        listCadete.Add(new Cadetes() { Id_cadete = Guid.Parse("0a9fa564-0604-4dfa-88df-3636fe395678"), Nombre = "Fer Hume", Direccion = "independencia", Telefono = "654321" });

        modelBuilder.Entity<Cadetes>(Cadete =>
        {
            Cadete.ToTable("Cadete");
            Cadete.HasKey(p => p.Id_cadete);

            Cadete.Property(p => p.Nombre).IsRequired().HasMaxLength(20);
            Cadete.Property(p => p.Direccion).IsRequired();
            Cadete.Property(p => p.Telefono).IsRequired();
            Cadete.Ignore(p => p.Listpedido);

            Cadete.HasData(listCadete);
        });

        List<Clientes> listaCliente = new List<Clientes>();
        listaCliente.Add(new Clientes() { Id_cliente = Guid.Parse("7b5e9399-8e95-4ae8-8745-9542a01e2cc3"), Nombre = "Pancho Castellanos", Direccion = "Entre rios", Telefono = "5231234" });
        listaCliente.Add(new Clientes() { Id_cliente = Guid.Parse("7b5e9399-8e95-4ae8-8745-9542a01e2cc1"), Nombre = "Lucio Hume", Direccion = "independencia", Telefono = "8321156" });
        listaCliente.Add(new Clientes() { Id_cliente = Guid.Parse("7b5e9399-8e95-4ae8-8745-9542a01e2cc5"), Nombre = "Val Hume", Direccion = "independencia", Telefono = "975313" });

        modelBuilder.Entity<Clientes>(Clientes =>
        {
            Clientes.ToTable("Cliente");
            Clientes.HasKey(p => p.Id_cliente);

            Clientes.Property(p => p.Id_cliente).IsRequired().ValueGeneratedOnAdd();
            Clientes.Property(p => p.Nombre).IsRequired().HasMaxLength(20);
            Clientes.Property(p => p.Direccion).IsRequired().HasMaxLength(100);
            Clientes.Property(p => p.Telefono).IsRequired().HasMaxLength(20);
            Clientes.Property(p => p.Referencia).IsRequired(false).HasMaxLength(100);

            Clientes.HasData(listaCliente);
        });

    }

}