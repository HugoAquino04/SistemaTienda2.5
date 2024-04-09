using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaTienda2._5.Models
{
    public class FacturaDetalle
    {
        [Key]
        public int FacturaDetalleId { get; set; }
        public int FacturaId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int ProductoId { get; set; }
        public decimal Precio { get; set; } = 0.10m;
        public decimal Total { get; set; } = 0.10m;
        public decimal Subtotal { get; set; } = 0.10m;
        public decimal Descuento { get; set; } = 0.10m;
    }
}