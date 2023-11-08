namespace CodingEvents.Models
{
    public class EventCategory
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        //Why won't this work

        public EventCategory()
        {

        }

        public EventCategory(string name)
        {
            Name = name;
        }

    }
}
