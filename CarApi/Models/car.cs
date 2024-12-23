namespace CarApi.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Vendor { get; set; } = string.Empty;
        public int Power { get; set; }
        public decimal Price { get; set; }
    }
}
