using System.ComponentModel.DataAnnotations;

namespace Lab4ChernClient.DataAccess.Model
{
    public class Seller
    {
        public int SellerId { get; set; }
        public string? SellerName { get; set; }
        public ICollection<Ticket>? Tickets { get; set; }
        public override string? ToString()
        {
            return $"SellerName:{SellerName}";
        }
    }
}
