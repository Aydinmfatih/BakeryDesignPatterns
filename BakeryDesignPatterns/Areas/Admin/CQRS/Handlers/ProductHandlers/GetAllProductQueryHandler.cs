using AutoMapper;
using BakeryDesignPatterns.Areas.Admin.CQRS.Results;
using BakeryDesignPatterns.DAL.Entities;
using BakeryDesignPatterns.DAL.Settings;
using MongoDB.Driver;

namespace BakeryDesignPatterns.Areas.Admin.CQRS.Handlers.ProductHandlers
{
    public class GetAllProductQueryHandler
    {
        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMapper _mapper;
        public GetAllProductQueryHandler(IDatabaseSettings databaseSettings, IMapper mapper)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _productCollection = database.GetCollection<Product>(databaseSettings.ProductCollecitonName);
            _mapper = mapper;
        }
        public List<GetAllProductQueryResult> Handle()
        {
            var values = _productCollection.Find(x => true).ToList();
            var results = values.Select(product => new GetAllProductQueryResult
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                ProductDescription = product.ProductDescription,
                ProductPrice = product.ProductPrice
            }).ToList();

            return results;

        }

    }
}
