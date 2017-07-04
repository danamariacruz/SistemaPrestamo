namespace CalculadoraIntereses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletetable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Prestamos");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Prestamos",
                c => new
                    {
                        PrestamoID = c.Int(nullable: false, identity: true),
                        Plazo = c.DateTime(nullable: false),
                        Interes = c.Double(nullable: false),
                        CantidadPrestada = c.Double(nullable: false),
                        Cuota = c.Double(nullable: false),
                        IdCliente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PrestamoID);
                
            
        }
    }
}
