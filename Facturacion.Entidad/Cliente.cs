using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Entidad
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string RazonSocial { get; set; }
        public string Ruc { get; set; }
        public string Direccion { get; set; }
        public Cliente()
        {
            IdCliente = 0;
            RazonSocial = string.Empty;
            Direccion = string.Empty;
        }
    }
}
