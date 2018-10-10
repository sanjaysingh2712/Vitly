namespace Vitly.DatabaseAccess.Core.Models
{
    public class MembershipType
    {
        public int MembershipTypeId { get; set; }
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}