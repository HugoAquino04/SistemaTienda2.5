using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaTienda2._5.Models
{
    [Table("FacturaDetalle")]
    public class FacturaDetalle
    {
        [Key]
        public int FacturaDetalleId { get; set; }

        public int FacturaId { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int ProductoId { get; set; }

        public decimal Precio { get; set; } = 0.10m;

        public decimal Total { get; set; } = 0.10m;

        public decimal SubTotal { get; set; } = 0.10m;

        public decimal Descuento { get; set; } = 0.10m;
    }
}