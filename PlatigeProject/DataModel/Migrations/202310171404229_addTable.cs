namespace DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TableTests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContractorName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TableTests");
        }
    }
}
