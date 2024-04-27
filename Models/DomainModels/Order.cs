namespace FuzzyArtStore.Models.DomainModels
{
    public class Order
    {
        public int OrderID { get; set; } // Primary key
        public int CustomerID { get; set; } // Foreign key to Customer
        public DateTime Date { get; set; } // Date the order was placed
        public decimal Total { get; set; } // Total price of the order

        // Navigation properties
        public virtual Client client { get; set; } = null!; // The customer who placed the order
        public virtual ICollection<OrderLines> OrderLines { get; set; } = new HashSet<OrderLines>(); // Details of items in the order
    }
}
