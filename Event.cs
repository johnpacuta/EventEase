using System.ComponentModel.DataAnnotations;

namespace EventEase
{
    public class Event
    {
        public int Id { get; set; }
       [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; }
        public bool IsCreated { get; private set; }

        // List to track customers attending the event
        public List<Customer> Attendees { get; set; } = new List<Customer>();

        public Event(int id, string name, DateTime date, string location)
        {
            Id = id;
            Name = name;
            Date = date;
            Location = location;
            IsCreated = true;
        }

        public Event()
        {
            Id = 0;
            Name = "";
            Date = DateTime.MinValue;
            Location = "";
            IsCreated = true;
        }

        // Method to add a customer to the attendees list
        public void AddAttendee(Customer customer)
        {
            if (!Attendees.Contains(customer))
            {
                Attendees.Add(customer);
            }
        }

        // Method to get the total number of attendees
        public int GetAttendanceCount()
        {
            return Attendees.Count;
        }
    }
}