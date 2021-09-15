using System;
using System.Collections.Generic;

using Facturacion.Entidad;

namespace Facturacion.Dao
{
    public class FacturaDAL
    {

        #region DLNT
        public IEnumerable<Factura> GetAll()
        {
            List<Factura> _facturas = new List<Factura>();
            _facturas.Add(new Factura()
            {
                Fecha = DateTime.Now,
                Cliente = new Cliente()
                {
                    RazonSocial = "Juana Perez",
                    Direccion = "Alameda los Alamos",
                    IdCliente = 1
                },
                IdFactura = 1,
                Total = 100
            });

            _facturas.Add(new Factura()
            {
                Fecha = DateTime.Now,
                Cliente = new Cliente()
                {
                    RazonSocial = "Román Ayala",
                    Direccion = "Av. Sucre",
                    IdCliente = 2
                },
                IdFactura = 2,
                Total = 100
            });

            return _facturas;
        }

        public Factura GetById(int id)
        {
            return new Factura()
            {
                Fecha = DateTime.Now,
                Cliente = new Cliente()
                {
                    RazonSocial = "Juana Perez",
                    Direccion = "Alameda los Alamos",
                    Ruc = "1072658755",
                    IdCliente = 1
                },
                IdFactura = 1,
                Total = 100
            };

        }

        #endregion

        #region DLT
        public int Insertar(Factura factura)
        {
            return 1;
        }

        public void Actualizar(Factura factura)
        {



        }

        public void Eliminar(int id)
        {

        }
        #endregion

    }
}
