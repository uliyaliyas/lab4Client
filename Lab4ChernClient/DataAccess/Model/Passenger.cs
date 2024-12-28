using Lab4ChernClient.DataAccess.Model;

namespace Lab4ChernClient.DataAccess.Model
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        public int Passport { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public ICollection<Ticket>? Tickets { get; set; }
        public override string? ToString()
        {
            return $"Name:{Name}, PhoneNumber:{PhoneNumber}," +
                $" Email:{Email},DateBirth:{DateBirth}";
        }
    }
}
