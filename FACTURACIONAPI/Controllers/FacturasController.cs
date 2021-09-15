using System;
using System.Web.Http;
using AutoMapper;

using Facturacion.Logic.BL;
using Facturacion.Logic.Dto;

namespace FACTURACIONAPI.Controllers
{
    public class FacturasController : ApiController
    {
        private readonly FacturaBL _facturaBL;
        public FacturasController()
        {
            _facturaBL = new FacturaBL();
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var facturas = _facturaBL.GetAll();

            if (facturas == null) return NotFound();

            return Ok(facturas);
        }

        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var factura = _facturaBL.GetById(id);

            if (factura == null) return NotFound();

            return Ok(factura);
        }

        [HttpPost]
        public IHttpActionResult Insertar(FacturaDto factura)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {

                _facturaBL.Insertar(factura);
                return Ok(factura);
            }
            catch (Exception exp)
            {
                return InternalServerError(exp);
            }


        }

        [HttpPut]
        public IHttpActionResult Actualizar(FacturaDto factura, int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (factura.IdFactura != id) return BadRequest();

            var _factura = _facturaBL.GetById(id);

            if (_factura == null) return NotFound();

            try
            {
                _facturaBL.Actualizar(factura);
                return Ok();
            }
            catch (Exception exp)
            {
                return InternalServerError(exp);
            }
        }

        [HttpDelete]
        public IHttpActionResult Eliminar(int id)
        {
            var _factura = _facturaBL.GetById(id);
            if (_factura == null) return NotFound();
            try
            {
                _facturaBL.Eliminar(id);
                return Ok();
            }
            catch (Exception exp)
            {
                return InternalServerError(exp);
            }


        }
    }
}
