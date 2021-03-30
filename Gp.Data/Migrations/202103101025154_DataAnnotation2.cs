namespace Gp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotation2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Products", name: "Quantity", newName: "Quantite");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Products", name: "Quantite", newName: "Quantity");
        }
    }
}
