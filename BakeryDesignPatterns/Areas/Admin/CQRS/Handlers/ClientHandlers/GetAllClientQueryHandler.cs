using AutoMapper;
using BakeryDesignPatterns.Areas.Admin.CQRS.Results;
using BakeryDesignPatterns.DAL.Entities;
using BakeryDesignPatterns.DAL.Settings;
using MongoDB.Driver;

namespace BakeryDesignPatterns.Areas.Admin.CQRS.Handlers.ClientHandlers
{
    public class GetAllClientQueryHandler
    {
        private readonly IMongoCollection<Client> _clientColleciton;
        private readonly IMapper _mapper;
        public GetAllClientQueryHandler(IDatabaseSettings databaseSettings, IMapper mapper)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _clientColleciton = database.GetCollection<Client>(databaseSettings.ProductCollecitonName);
            _mapper = mapper;
        }
        public List<GetAllClientQueryResult> Handle()
        {
            var values = _clientColleciton.Find(x => true).ToList();
            var results = values.Select(client => new GetAllClientQueryResult
            {
                ClientId = client.ClientId,
                ClientName = client.ClientName,
                ImageUrl = client.ImageUrl,
                Title = client.Title    
            }).ToList();

            return results;
        }
    }
}
