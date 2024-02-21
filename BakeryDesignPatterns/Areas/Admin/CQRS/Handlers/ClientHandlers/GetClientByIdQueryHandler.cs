using AutoMapper;
using BakeryDesignPatterns.Areas.Admin.CQRS.Querys;
using BakeryDesignPatterns.Areas.Admin.CQRS.Results;
using BakeryDesignPatterns.DAL.Entities;
using BakeryDesignPatterns.DAL.Settings;
using MongoDB.Driver;

namespace BakeryDesignPatterns.Areas.Admin.CQRS.Handlers.ClientHandlers
{
    public class GetClientByIdQueryHandler
    {
        private readonly IMongoCollection<Client> _clientColleciton;
        private readonly IMapper _mapper;
        public GetClientByIdQueryHandler(IDatabaseSettings databaseSettings, IMapper mapper)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _clientColleciton = database.GetCollection<Client>(databaseSettings.ProductCollecitonName);
            _mapper = mapper;
        }
        public GetClientByIdQueryResult Handle(GetClientByIdQuery query)
        {
            var value = _clientColleciton.Find(x => x.ClientId == query.Id).FirstOrDefault();

            var results = new GetClientByIdQueryResult
            {
               ClientId = value.Id,
               ClientName=value.ClientName,
               Title=value.Title,
               ImageUrl =value.ImageUrl
            };
            return results;
        }
    }
}
