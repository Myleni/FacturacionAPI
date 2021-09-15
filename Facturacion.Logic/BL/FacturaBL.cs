using System.Collections.Generic;
using System.Linq;
using AutoMapper;

using Facturacion.Entidad;
using Facturacion.Dao;
using Facturacion.Logic.Dto;


namespace Facturacion.Logic.BL
{
    public class FacturaBL
    {
        private readonly FacturaDAL _facturaDal;
        private readonly IMapper _mapper;
        public FacturaBL()
        {
            _facturaDal = new FacturaDAL();
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();

        }
        public IEnumerable<FacturaDto> GetAll()
        {
            return _facturaDal.GetAll().Select(x => _mapper.Map<FacturaDto>(x));

        }

        public FacturaDto GetById(int id)
        {
            var factura = _facturaDal.GetById(id);
            return _mapper.Map<FacturaDto>(factura);

        }
        public int Insertar(FacturaDto factura)
        {

            Factura facturaEntidad = _mapper.Map<Factura>(factura);
            return _facturaDal.Insertar(facturaEntidad);

        }
        public void Actualizar(FacturaDto factura)
        {

            Factura facturaEntidad = _mapper.Map<Factura>(factura);

            _facturaDal.Actualizar(facturaEntidad);

        }
        public void Eliminar(int id)
        {
            _facturaDal.Eliminar(id);

        }
    }
}
