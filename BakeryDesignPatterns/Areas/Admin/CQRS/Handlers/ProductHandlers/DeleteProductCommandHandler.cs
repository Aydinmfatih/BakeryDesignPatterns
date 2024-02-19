using BakeryDesignPatterns.Areas.Admin.CQRS.Commands.Product;
using BakeryDesignPatterns.DAL.Entities;
using BakeryDesignPatterns.DAL.Settings;
using MongoDB.Driver;

namespace BakeryDesignPatterns.Areas.Admin.CQRS.Handlers.ProductHandlers
{
    public class DeleteProductCommandHandler
    {
        private readonly IMongoCollection<Product> _productCollection;
        public DeleteProductCommandHandler(IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _productCollection = database.GetCollection<Product>(databaseSettings.ProductCollecitonName);
        }

        public void Handle(DeleteProductCommand command)
        {
            var values = _productCollection.DeleteOne(x => x.ProductId == command.Id);
        }
    }
}
