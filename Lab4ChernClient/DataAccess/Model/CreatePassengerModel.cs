using System.ComponentModel.DataAnnotations;


namespace Lab4ChernClient.DataAccess.Model
{
    public class CreatePassengerModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }
       
        public string? DateBirth { get; set; }
       
        public int Passport { get; set; }
        [Required(ErrorMessage ="PhoneNumber is required")]
        public string? PhoneNumber {  get; set; }
      
        public string? Email { get; set; }

    }
}
