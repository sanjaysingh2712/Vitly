namespace Vitly.DatabaseAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(SignUpFee, DurationInMonths, DiscountRate) VALUES (0, 0, 0)");
            Sql("INSERT INTO MembershipTypes(SignUpFee, DurationInMonths, DiscountRate) VALUES (30, 1, 10)");
            Sql("INSERT INTO MembershipTypes(SignUpFee, DurationInMonths, DiscountRate) VALUES (90, 3, 15)");
            Sql("INSERT INTO MembershipTypes(SignUpFee, DurationInMonths, DiscountRate) VALUES (300, 3, 15)");

        }
        
        public override void Down()
        {
            Sql("DELETE FROM MembershipTypes WHERE MembershipTypeId IN (1, 2, 3, 4)");
        }
    }
}
