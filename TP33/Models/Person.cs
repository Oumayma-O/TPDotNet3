namespace TP33.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public string Email { get; set; }
        public string DateBirth { get; set; }
        public string Country { get; set; }

        public Person(int Id, string FirstName ,string Lastname , string Email , string DateBirth , string Country)
        {
            Id = Id; FirstName = FirstName; LastName = LastName; Email = Email; DateBirth = DateBirth; Country = Country;

        }
        public Person()
        {

        }

    }
}
