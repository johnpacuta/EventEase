namespace EventEase
{
    public class EventService
    {
        public List<Event> Events { get; private set; } = new List<Event>
        {
            new Event
            {
                Id = 1,
                Name = "Matthew Good Concert",
                Date = new DateTime(2025, 6, 15),
                Location = "Toronto, ON",
            },
            new Event
            {
                Id = 2,
                Name = "Jazz Night",
                Date = new DateTime(2025, 7, 10),
                Location = "Montreal, QC",
            },
            new Event
            {
                Id = 3,
                Name = "Rock Festival",
                Date = new DateTime(2025, 8, 20),
                Location = "Vancouver, BC",
            }
        };

        public event Action? OnChange;

        public void NotifyStateChanged()
        {
            OnChange?.Invoke();
        }
    }
}