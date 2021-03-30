namespace Gp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Category_CategoryId" });
            RenameColumn(table: "dbo.Products", name: "Category_CategoryId", newName: "CategoryKey");
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Description", c => c.String(maxLength: 450));
            AlterColumn("dbo.Products", "CategoryKey", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "CategoryKey");
            AddForeignKey("dbo.Products", "CategoryKey", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryKey", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryKey" });
            AlterColumn("dbo.Products", "CategoryKey", c => c.Int());
            AlterColumn("dbo.Products", "Description", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
            RenameColumn(table: "dbo.Products", name: "CategoryKey", newName: "Category_CategoryId");
            CreateIndex("dbo.Products", "Category_CategoryId");
            AddForeignKey("dbo.Products", "Category_CategoryId", "dbo.Categories", "CategoryId");
        }
    }
}
