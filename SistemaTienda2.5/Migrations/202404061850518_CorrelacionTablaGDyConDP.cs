namespace SistemaTienda2._5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrelacionTablaGDyConDP : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Cliente", "GrupoDescuentoId");
            CreateIndex("dbo.Cliente", "CondicionPagoId");
            AddForeignKey("dbo.Cliente", "CondicionPagoId", "dbo.CondicionPago", "CondicionPagoId");
            AddForeignKey("dbo.Cliente", "GrupoDescuentoId", "dbo.GrupoDescuento", "GrupoDescuentoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cliente", "GrupoDescuentoId", "dbo.GrupoDescuento");
            DropForeignKey("dbo.Cliente", "CondicionPagoId", "dbo.CondicionPago");
            DropIndex("dbo.Cliente", new[] { "CondicionPagoId" });
            DropIndex("dbo.Cliente", new[] { "GrupoDescuentoId" });
        }
    }
}
