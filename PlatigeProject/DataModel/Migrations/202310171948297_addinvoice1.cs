namespace DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addinvoice1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.InvoiceModels", "ContractorId", "dbo.ContractorModels");
            DropIndex("dbo.InvoiceModels", new[] { "ContractorId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.InvoiceModels", "ContractorId");
            AddForeignKey("dbo.InvoiceModels", "ContractorId", "dbo.ContractorModels", "Id", cascadeDelete: true);
        }
    }
}
