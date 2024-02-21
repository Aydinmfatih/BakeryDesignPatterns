namespace BakeryDesignPatterns.Areas.Admin.CQRS.Commands.Client
{
    public class DeleteClientCommand
    {
        public DeleteClientCommand(string id)
        {
            Id = id;
        }
        public string Id { get; set; }
     

    }
}
