using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Lab4ChernClient.DataAccess.Model
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int FlightId { get; set; }
        public int PassengerId { get; set; }
        public int SellerID { get; set; }
        public int SeatNumber { get; set; }
        public DateTime? BuyDateTime { get; set; }
        public double Price { get; set; }
        public bool IsChild { get; set; }
        public override string ToString()
        {
            return $"BuyDateTime:{BuyDateTime}";
        }
    }
}
