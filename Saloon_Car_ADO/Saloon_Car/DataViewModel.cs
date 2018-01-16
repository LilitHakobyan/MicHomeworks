namespace Saloon_Car
{
    public class DataViewModel:EntityBase
    {
        
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public bool Sold  { get; set; }
        public bool Deleted { get; set; }


    }
}
