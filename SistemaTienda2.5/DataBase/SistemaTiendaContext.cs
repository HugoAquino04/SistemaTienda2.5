using SistemaTienda2._5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SistemaTienda2._5.DataBase
{
    public class SistemaTiendaContext : DbContext
    {
        public SistemaTiendaContext() : base("name = SistemaTienda")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        public DbSet<Cliente> Clientes { get; set; } 
        public DbSet<GrupoDescuento> GrupoDescuentos { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<UnidadMedida> UnidadMedida { get; set; }
        public DbSet<CondicionPago> CondicionPago { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoDetalle> PedidoDetalle { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<FacturaDetalle> FacturaDetalle { get;set; }
    }
}