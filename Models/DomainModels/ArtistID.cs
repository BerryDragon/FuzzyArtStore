namespace FuzzyArtStore.Models.DomainModels
{
    public class ArtistID
    {
        public int VendorID { get; set; } 
        public string Name { get; set; } = string.Empty; 
        public string WebURL { get; set; } = string.Empty; // Vendor's website URL
        public float OverallRating { get; set; } // Overall rating received from customer reviews

        // Navigation properties
        public virtual ICollection<Merch> Merchandise { get; set; } = new HashSet<Merch>(); // Merchandise supplied by the vendor
    }
}
