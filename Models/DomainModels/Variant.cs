namespace FuzzyArtStore.Models.DomainModels
{
    public class Variant
    {
        public int VariantID { get; set; } // Primary key
        public int MerchID { get; set; } // Foreign key to Merch
        public string Color { get; set; } = string.Empty; // Color of the variant
        public string Size { get; set; } = string.Empty; // Size of the variant

        // Navigation property
        public virtual Merch Merch { get; set; } = null!;
    }
}
