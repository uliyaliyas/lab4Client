using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Lab4ChernClient.DataAccess.Model
{
    public class Flight
    {
        public int FlightId { get; set; }
        public int FlightNumber { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int PlaneType { get; set; }
        public int Seats { get; set; }
        public ICollection<Ticket>? Tickets { get; set; }
        public override string? ToString()
        {
            return $"DepartureAirport:{DepartureAirport}, ArrivalAirport:{ArrivalAirport}," +
                $"DepartureDate:{DepartureDate},ArrivalDate:{ArrivalDate}";
        }
    }
}
