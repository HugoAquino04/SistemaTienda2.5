﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaTienda2._5.Models
{
    [Table("GrupoDescuento")]
    public class GrupoDescuento
    {

        [Key]
        public int GrupoDescuentoId { get; set; }

        [MaxLength(50)]
        public string Codigo { get; set; }

        [MaxLength(50)]
        public string Descripcion { get; set; }

        public bool Estado { get; set; }

        public int Porcentaje { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}