namespace FuzzyArtStore.Models.DomainModels
{
    public class Client
    {
        public int CustomerID { get; set; } // PK
        public string FirstName { get; set; } = string.Empty; 
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty; 

        // Navigation properties
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>(); // Orders placed by the custome
    }
}
