namespace SistemaTienda2._5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdiccionTablaFactura1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Factura", "PedidoId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Factura", "PedidoId");
        }
    }
}
