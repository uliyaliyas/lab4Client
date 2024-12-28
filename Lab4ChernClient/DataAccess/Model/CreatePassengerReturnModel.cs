namespace Lab4ChernClient.DataAccess.Model
{
    public class CreatePassengerReturnModel
    {
        public int PassengerId { get; set; }
        public string? Name { get; set; }
        public DateTime DateBirth { get; set; }
        public int Passport { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
    }
}
