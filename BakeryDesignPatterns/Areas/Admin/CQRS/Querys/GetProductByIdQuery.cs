namespace BakeryDesignPatterns.Areas.Admin.CQRS.Querys
{
    public class GetProductByIdQuery
    {
        public GetProductByIdQuery(string id)
        {
            Id = id;
        }
        public string Id { get; set; }
    }
}
