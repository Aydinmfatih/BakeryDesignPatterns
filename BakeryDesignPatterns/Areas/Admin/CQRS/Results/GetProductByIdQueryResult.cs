namespace BakeryDesignPatterns.Areas.Admin.CQRS.Results
{
    public class GetProductByIdQueryResult
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public string ImageUrl { get; set; }
    }
}
