namespace BakeryDesignPatterns.Areas.Admin.CQRS.Commands.Client
{
    public class CreateClientCommand
    {

        public string ClientName { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }

    }
}
