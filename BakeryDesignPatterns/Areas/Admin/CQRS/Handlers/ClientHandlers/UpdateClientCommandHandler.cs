using AutoMapper;
using BakeryDesignPatterns.Areas.Admin.CQRS.Commands.Client;
using BakeryDesignPatterns.DAL.Entities;
using BakeryDesignPatterns.DAL.Settings;
using MongoDB.Driver;

namespace BakeryDesignPatterns.Areas.Admin.CQRS.Handlers.ClientHandlers
{
    public class UpdateClientCommandHandler
    {
        private readonly IMongoCollection<Client> _clientColleciton;
        private readonly IMapper _mapper;
        public UpdateClientCommandHandler(IDatabaseSettings databaseSettings, IMapper mapper)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _clientColleciton = database.GetCollection<Client>(databaseSettings.ProductCollecitonName);
            _mapper = mapper;
        }
        public void Handle(UpdateClientCommand command)
        {
            var filter = Builders<Client>.Filter.Eq(p => p.ClientName, command.ClientId);
            var update = Builders<Client>.Update
                .Set(p => p.ClientName, command.ClientName)
                .Set(p => p.Title, command.Title)
                .Set(p => p.ImageUrl, command.ImageUrl)
                .Set(p => p., command.ImageUrl);

            _clientColleciton.UpdateOne(filter, update);
        }
    }
}
