using AutoMapper;
using BakeryDesignPatterns.Areas.Admin.CQRS.Commands.Product;
using BakeryDesignPatterns.DAL.Entities;
using BakeryDesignPatterns.DAL.Settings;
using MongoDB.Driver;

namespace BakeryDesignPatterns.Areas.Admin.CQRS.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler
    {
        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMapper _mapper;
        public UpdateProductCommandHandler(IDatabaseSettings databaseSettings, IMapper mapper)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _productCollection = database.GetCollection<Product>(databaseSettings.ProductCollecitonName);
            _mapper = mapper;
        }
        public void Handle(UpdateProductCommand command)
        {
            var filter = Builders<Product>.Filter.Eq(p => p.ProductId, command.ProductId); 
            var update = Builders<Product>.Update
                .Set(p => p.ProductName, command.ProductName) 
                .Set(p => p.ProductDescription, command.ProductDescription) 
                .Set(p => p.ProductPrice, command.ProductPrice); 

            _productCollection.UpdateOne(filter, update); 
            
        }
    }
}
