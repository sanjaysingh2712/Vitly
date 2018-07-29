namespace Vitly.DatabaseAccess.Core.Model
{
    public class MembershipType
    {
        public int MembershipTypeId { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}