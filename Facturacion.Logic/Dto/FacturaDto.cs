using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Facturacion.Logic.Dto
{
    public class FacturaDto
    {
        [Required(ErrorMessage ="El Campo es requerido")]
        public int IdFactura { get; set; }

        [Required(ErrorMessage = "La fecha de la factura es requerida")]
        public DateTime Fecha { get; set; }

        [Required]
        public decimal Total { get; set; }

        [Required]
        [StringLength(200)]
        public string RazonSocial { get; set; }

        [Required]
        [StringLength(11,ErrorMessage ="Ruc inválido")]
        public string Ruc { get; set; }

        [StringLength(200)]
        public string Direccion { get; set; }

        public FacturaDto()
        {
           
        }
    }
}
