namespace CalculadoraIntereses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modificacion3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Direccion", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Direccion", c => c.String());
        }
    }
}
