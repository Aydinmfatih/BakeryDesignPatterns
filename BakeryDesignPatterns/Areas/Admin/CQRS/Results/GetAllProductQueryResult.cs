namespace BakeryDesignPatterns.Areas.Admin.CQRS.Results
{
    public class GetAllProductQueryResult
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
