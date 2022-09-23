namespace MaterialValues.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _123 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NameOFOrganization = c.String(),
                        NumberOfDocument = c.Int(nullable: false),
                        DateOfDocument = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Values",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Count = c.Int(nullable: false),
                        PriceForOneCount = c.Int(nullable: false),
                        Size = c.Single(nullable: false),
                        Width = c.Single(nullable: false),
                        Length = c.Single(nullable: false),
                        Height = c.Single(nullable: false),
                        SerialNumber = c.Int(nullable: false),
                        Info = c.String(),
                        SipplierID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Values");
            DropTable("dbo.Suppliers");
        }
    }
}
