namespace Vitly.DatabaseAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MempershipType_MembershipTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "MempershipType_SignUpFee", c => c.Short(nullable: false));
            AddColumn("dbo.Customers", "MempershipType_DurationInMonths", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "MempershipType_DiscountRate", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "MembershipTypeId");
            DropColumn("dbo.Customers", "MempershipType_DiscountRate");
            DropColumn("dbo.Customers", "MempershipType_DurationInMonths");
            DropColumn("dbo.Customers", "MempershipType_SignUpFee");
            DropColumn("dbo.Customers", "MempershipType_MembershipTypeId");
        }
    }
}
