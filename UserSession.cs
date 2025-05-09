namespace EventEase
{
    public class UserSession
    {
        public int? CurrentEventId { get; set; }
        public List<Customer> RegisteredCustomers { get; set; } = new List<Customer>();

        public void RegisterCustomer(Customer customer)
        {
            RegisteredCustomers.Add(customer);
        }

        public void ClearSession()
        {
            CurrentEventId = null;
            RegisteredCustomers.Clear();
        }

        public List<Event> TrackedEvents { get; set; } = new List<Event>();

        public void TrackEvent(Event eventItem)
        {
            if (!TrackedEvents.Contains(eventItem))
            {
                TrackedEvents.Add(eventItem);
            }
        }

        public void ClearTrackedEvents()
        {
            TrackedEvents.Clear();
        }
    }
}