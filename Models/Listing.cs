namespace eBayListerAPI.Models
{
    public class Listing
    {
        public int ID { get; set; }
        public string StoreCategoryID { get; set; }
        public string Title { get; set; }
        public string Photo1Path { get; set; }
        public string Photo2Path { get; set; }
        public decimal Price { get; set; }
        public bool Listed { get; set; }
        public bool Sold { get; set; }
        public int Condition { get; set; }
        public int WeightLBS { get; set; }
        public int WeightOZ { get; set; }
        public string Description { get; set;}
    }
}