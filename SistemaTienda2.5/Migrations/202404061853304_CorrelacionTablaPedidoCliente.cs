namespace SistemaTienda2._5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrelacionTablaPedidoCliente : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Pedido", "ClienteId");
            AddForeignKey("dbo.Pedido", "ClienteId", "dbo.Cliente", "ClienteId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedido", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Pedido", new[] { "ClienteId" });
        }
    }
}
