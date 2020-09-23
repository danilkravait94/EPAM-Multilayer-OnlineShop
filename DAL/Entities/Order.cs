
using DAL.Enums;

namespace DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Statuses Status { get; set; }
        public string Country { get; set; }
        public int NumberOfPost { get; set; }
    }
}
