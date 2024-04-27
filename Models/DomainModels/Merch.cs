namespace FuzzyArtStore.Models.DomainModels
{
    public class Merch
    {
        public int MerchID { get; set; }
        public int ArtistID { get; set;}

        public string ItemName { get; set; } = string.Empty;
        public string ItemDescription { get; set; } = string.Empty;


    }
}
