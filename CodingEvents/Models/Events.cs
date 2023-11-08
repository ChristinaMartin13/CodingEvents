using System;
namespace CodingEvents.Models
{
    public class Events
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        public string? ContactEmail { get; set; }

        public EventType Type { get; set; }



      
    

        public int Id { get; set; }
       

        public Events()
        {
        }
        public Events (string name, string description, string contactEmail)
        {
            Name = name;
            Description = description;
            ContactEmail = contactEmail;
        }

        public override string? ToString()
        {
            return Name;
        }

        public override bool Equals(object? obj)
        {
            return obj is Events @events && Id == @events.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }

}
