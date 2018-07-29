namespace Vitly.DatabaseAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        MembershipTypeId = c.Int(nullable: false, identity: true),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.MembershipTypeId);
            
            CreateIndex("dbo.Customers", "MembershipTypeId");
            AddForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes", "MembershipTypeId", cascadeDelete: false);
            DropColumn("dbo.Customers", "MempershipType_MembershipTypeId");
            DropColumn("dbo.Customers", "MempershipType_SignUpFee");
            DropColumn("dbo.Customers", "MempershipType_DurationInMonths");
            DropColumn("dbo.Customers", "MempershipType_DiscountRate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MempershipType_DiscountRate", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "MempershipType_DurationInMonths", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "MempershipType_SignUpFee", c => c.Short(nullable: false));
            AddColumn("dbo.Customers", "MempershipType_MembershipTypeId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            DropTable("dbo.MembershipTypes");
        }
    }
}
