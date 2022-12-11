namespace TP33.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public string Email { get; set; }
        public string DateBirth { get; set; }
        public string image { get; set; }
        public string Country { get; set; }

        public Person(int Id, string FirstName ,string Lastname , string Email ,string image , string Country)
        {
            this.Id = Id; this.FirstName = FirstName; this.LastName = LastName; this.Email = Email;  this.image = image; this.Country = Country;

        }
        public Person()
        {

        }

    }
}
