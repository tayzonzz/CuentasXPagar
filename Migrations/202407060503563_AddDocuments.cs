namespace CuentasXPagar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDocuments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DocumentsModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DocumentNumber = c.String(),
                        InvoiceNumber = c.String(),
                        DocumentDate = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RecordDate = c.DateTime(nullable: false),
                        Proveedor = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DocumentsModels");
        }
    }
}
