using System.ComponentModel.DataAnnotations.Schema;

namespace cadeteria.Models;

public class Cadetes : Persona
{
    //clase hija que hereda de persona sus atributos que comparten
    //relacion de agregacion con los pedidos;
    //private List<Pedido> listpedido = new List<Pedido>();

    //[NotMapped]
    //public List<Pedido> Listpedido { get => listpedido; set => listpedido = value; }

    public Cadetes(int id, string name, string adress, string phone) : base(id, name, adress, phone)
    {
        this.Id = id;
        this.Nombre = name;
        this.Direccion = adress;
        this.Telefono = phone;
    }
    public Cadetes() { }




}
