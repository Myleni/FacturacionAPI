using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Entidad
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public Cliente Cliente { get; set; }

        public Factura()
        {
            IdFactura = 0;
            Fecha = DateTime.Now;
            Total = 0;
            Cliente = new Cliente();
        }
    }
}
