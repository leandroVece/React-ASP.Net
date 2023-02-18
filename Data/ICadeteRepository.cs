using cadeteria.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace cadeteria;


public interface ICadeteRepository
{

    IEnumerable<Cadetes> Get();
    Task Save(Cadetes cadete);
    Task Update(Guid id, Cadetes cadete);
    Task Delete(Guid id);
    /*SQLiteConnection Conexion();
    public void Update(Cadete cadete);
    public void Delete(int id);
    public void Create(Cadete cadete);

    List<Cadete> GetCadete();
    Cadete GetCadeteById(int id);*/

}

