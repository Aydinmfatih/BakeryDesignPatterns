namespace BakeryDesignPatterns.Areas.Admin.CQRS.Commands.Product
{
    public class CreateProductCommand
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public string ImageUrl { get; set; }
    }
}
