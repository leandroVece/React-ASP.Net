using System.ComponentModel.DataAnnotations.Schema;
namespace cadeteria.Models;

public class Clientes
{

    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    private Guid id_cliente;
    private string nombre, direccion, telefono;
    private string referencia;


    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public string Referencia { get => referencia; set => referencia = value; }
    public Guid Id_cliente { get => id_cliente; set => id_cliente = value; }

    public Clientes(Guid id_cliente, string name, string adress, string phone, string referencia)
    {
        this.Id_cliente = id_cliente;
        this.Nombre = name;
        this.Direccion = adress;
        this.Telefono = phone;
        this.Referencia = referencia;
    }
    public Clientes(Guid Id_cliente, string name, string adress, string phone)
    {
        this.Id_cliente = this.Id_cliente;
        this.Nombre = name;
        this.Direccion = adress;
        this.Telefono = phone;

    }

    public Clientes()
    {

    }

}
