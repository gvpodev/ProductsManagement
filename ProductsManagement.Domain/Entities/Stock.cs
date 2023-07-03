namespace ProductsManagement.Domain.Entities
{
    public class Stock
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime? CreationDate { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
