namespace Test_Assignment_3.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }

        public  string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public List<Booking> Bookings { get; set; } = new List<Booking>();


    }
}
