using System.ComponentModel.DataAnnotations.Schema;

namespace cadeteria.Models;

public class Cadetes : Persona
{
    private Guid id_cadete;
    private string nombre, direccion, telefono;

    public Guid Id_cadete { get => id_cadete; set => id_cadete = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    private List<Pedido> listpedido = new List<Pedido>();

    [NotMapped]
    public List<Pedido> Listpedido { get => listpedido; set => listpedido = value; }
    public Cadetes(Guid id_cadete, string name, string adress, string phone)
    {
        this.Id_cadete = id_cadete;
        this.Nombre = name;
        this.Direccion = adress;
        this.Telefono = phone;
    }
    public Cadetes() { }




}
