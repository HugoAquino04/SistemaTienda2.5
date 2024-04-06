﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaTienda2._5.Models
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }

        public int CategoriaId { get; set; }

        public int UnidadMedidaId { get; set; }

        public DateTime FechaCreacion { get; set; }

        public bool Estado { get; set; }

        public decimal PrecioCompra { get; set; } = 0.10m;
    }
}