using AutoMapper;
using BakeryDesignPatterns.Areas.Admin.CQRS.Commands.Client;
using BakeryDesignPatterns.DAL.Entities;
using BakeryDesignPatterns.DAL.Settings;
using MongoDB.Driver;

namespace BakeryDesignPatterns.Areas.Admin.CQRS.Handlers.ClientHandlers
{

    public class DeleteClientCommandHandler
    {
        private readonly IMongoCollection<Client> _clientColleciton;
        private readonly IMapper _mapper;
        public DeleteClientCommandHandler(IDatabaseSettings databaseSettings, IMapper mapper)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _clientColleciton = database.GetCollection<Client>(databaseSettings.ProductCollecitonName);
            _mapper = mapper;
        }

        public void Handle(DeleteClientCommand command)
        {
            _clientColleciton.DeleteOne(x => x.ClientId == command.Id);
            
        }
    }
}
