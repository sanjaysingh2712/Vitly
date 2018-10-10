namespace Vitly.DatabaseAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addnametomembershiptype : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            Sql("UPDATE MembershipTypes SET Name = 'Pay as you go' WHERE MembershipTypeId = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE MembershipTypeId = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly' WHERE MembershipTypeId = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Annual' WHERE MembershipTypeId = 4");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
