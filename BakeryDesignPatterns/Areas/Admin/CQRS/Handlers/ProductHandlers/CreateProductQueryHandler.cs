using AutoMapper;
using BakeryDesignPatterns.Areas.Admin.CQRS.Commands.Product;
using BakeryDesignPatterns.Areas.Admin.CQRS.Results;
using BakeryDesignPatterns.DAL.Entities;
using BakeryDesignPatterns.DAL.Settings;
using MongoDB.Driver;

namespace BakeryDesignPatterns.Areas.Admin.CQRS.Handlers.ProductHandlers
{
    public class CreateProductQueryHandler
    {
        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMapper _mapper;
        public CreateProductQueryHandler(IDatabaseSettings databaseSettings, IMapper mapper)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _productCollection = database.GetCollection<Product>(databaseSettings.ProductCollecitonName);
            _mapper = mapper;
        }
        public void Handle(CreateProductCommand command)
        {
            var value = _mapper.Map<Product>(command);
            _productCollection.InsertOne(value);


        }
    }
}
