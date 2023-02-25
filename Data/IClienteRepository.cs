using cadeteria.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using System.Data.SQLite;


namespace cadeteria;


public interface IClienteRepository
{
    IEnumerable<Clientes> Get();
    public Clientes GetById(Guid id);
    Task Save(Clientes cliente);
    Task Update(Guid id, Clientes cliente);
    Task Delete(Guid id);
    // SQLiteConnection Conexion();
    // public void Update(Cliente cliente);
    // public void Delete(int id);
    // public void Create(Cliente cliente);

    // List<Cliente> GetCliente();
    // Cliente GetClienteById(int id);

}

