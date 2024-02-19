namespace BakeryDesignPatterns.Areas.Admin.CQRS.Commands.Product
{
    public class DeleteProductCommand
    {
        public DeleteProductCommand(string id)
        {
            Id= id;
        }
        public string Id { get; set; }
    }
}

