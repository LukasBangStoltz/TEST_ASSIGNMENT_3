namespace Test_Assignment_3.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
