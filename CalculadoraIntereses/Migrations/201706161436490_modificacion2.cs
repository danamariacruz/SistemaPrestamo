namespace CalculadoraIntereses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modificacion2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Direccion", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Direccion");
        }
    }
}
