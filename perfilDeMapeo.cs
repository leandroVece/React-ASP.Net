using AutoMapper;
using cadeteria.Models;
using VuiwModels;

public class perfilDeMapeo : Profile
{
    public perfilDeMapeo()
    {
        CreateMap<Usuario, UserViewModel>().ReverseMap();
        CreateMap<Usuario, UserLoginViewModel>().ReverseMap();
        CreateMap<Usuario, UserUpdateViewModel>().ReverseMap();

        CreateMap<Cadetes, CadeteViewModel>().ReverseMap();
        CreateMap<Cadetes, CadeteUpdateViewModel>().ReverseMap();

        CreateMap<Pedido, PedidoViewModel>().ReverseMap();
        CreateMap<Clientes, ClienteViewModel>().ReverseMap();
    }
}
