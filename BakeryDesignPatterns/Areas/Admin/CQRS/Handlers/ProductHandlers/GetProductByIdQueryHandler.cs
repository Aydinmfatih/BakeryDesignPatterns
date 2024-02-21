using AutoMapper;
using BakeryDesignPatterns.Areas.Admin.CQRS.Querys;
using BakeryDesignPatterns.Areas.Admin.CQRS.Results;
using BakeryDesignPatterns.DAL.Entities;
using BakeryDesignPatterns.DAL.Settings;
using MongoDB.Driver;

namespace BakeryDesignPatterns.Areas.Admin.CQRS.Handlers.ProductHandlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IDatabaseSettings databaseSettings, IMapper mapper)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _productCollection = database.GetCollection<Product>(databaseSettings.ProductCollecitonName);
            _mapper = mapper;
        }
        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var value = _productCollection.Find(x=>x.ProductId == query.Id).FirstOrDefault();

            var results = new GetProductByIdQueryResult
            {
                ProductId = value.ProductId,
                ProductName = value.ProductName,
                ProductDescription = value.ProductDescription,
                ProductPrice = value.ProductPrice,
                ImageUrl = value.ImageUrl
            };
            return results;
        }

    }
}
