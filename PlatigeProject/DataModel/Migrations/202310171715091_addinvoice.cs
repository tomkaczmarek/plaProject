namespace DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addinvoice : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContractorModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Name = c.String(),
                        ShortName = c.String(),
                        Country = c.String(),
                        Adress = c.String(),
                        NipNumber = c.Int(nullable: false),
                        IsActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InvoiceModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContractorId = c.Int(nullable: false),
                        Number = c.String(),
                        NetValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Currency = c.String(),
                        Vat = c.Int(nullable: false),
                        TransactionDate = c.DateTime(nullable: false),
                        Info = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ContractorModels", t => t.ContractorId, cascadeDelete: true)
                .Index(t => t.ContractorId);
            
            DropTable("dbo.TableTests");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TableTests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContractorName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.InvoiceModels", "ContractorId", "dbo.ContractorModels");
            DropIndex("dbo.InvoiceModels", new[] { "ContractorId" });
            DropTable("dbo.InvoiceModels");
            DropTable("dbo.ContractorModels");
        }
    }
}
