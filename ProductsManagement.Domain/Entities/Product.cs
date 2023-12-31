﻿namespace ProductsManagement.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }

        public Guid StockId { get; set; }
        public Guid CategoryId { get; set; }
        public Stock? Stock { get; set; }
        public Category? Category { get; set; }
    }
}
