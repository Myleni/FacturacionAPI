using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Entidad
{
    public class FacturaDetalle
    {
        public int IdFacturaDetalle { get; set; }
        public int IdFactura { get; set; }
        public int Cantidad { get; set; }
        public int Monto { get; set; }
        public Item Item { get; set; }

        public FacturaDetalle()
        {
            IdFacturaDetalle = 0;
            IdFactura = 0;
            Cantidad = 0;
            Monto = 0;
        }
    }
}
