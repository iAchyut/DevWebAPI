namespace DevWebAPI.Models
{
    public class Employee
    {
        public Guid ID { get; set; }

        public string Fistname { get; set; }

        public string Lastname { get; set; }

        public required string email { get; set; }

        public string? Phone { get; set;  }

    }
}
