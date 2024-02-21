namespace BakeryDesignPatterns.Areas.Admin.CQRS.Querys
{
    public class GetClientByIdQuery
    {
        public GetClientByIdQuery(string id)
        {
            Id = id;

        }
        public string Id { get; set; }
    }
}
