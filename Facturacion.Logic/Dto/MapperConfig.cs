using AutoMapper;
using Facturacion.Logic.Dto;
using Facturacion.Entidad;

namespace Facturacion.Logic.Dto
{
    public class MapperConfig
    {
        public static MapperConfiguration MapperConfiguration()
        {
            return new MapperConfiguration(item =>
            {
                item.CreateMap<Factura, FacturaDto>()
                .ForMember(dto=>dto.Direccion,mc=>mc.MapFrom(x=>x.Cliente.Direccion))
                .ForMember(dto => dto.RazonSocial, mc => mc.MapFrom(x => x.Cliente.RazonSocial))
                .ForMember(dto => dto.Ruc, mc => mc.MapFrom(x => x.Cliente.Ruc))
                ;
                item.CreateMap<FacturaDto, Factura>();
                    

                item.CreateMap<Cliente, ClienteDto>();
                item.CreateMap<ClienteDto, Cliente>();
            });
        }
    }
}
