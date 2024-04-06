﻿namespace SistemaTienda2._5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdiccionTablaFacturaDetalle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FacturaDetalle",
                c => new
                    {
                        FacturaDetalleId = c.Int(nullable: false, identity: true),
                        FacturaId = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.FacturaDetalleId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FacturaDetalle");
        }
    }
}
