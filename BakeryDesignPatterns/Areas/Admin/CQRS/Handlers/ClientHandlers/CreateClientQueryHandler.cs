using AutoMapper;
using BakeryDesignPatterns.Areas.Admin.CQRS.Commands.Client;
using BakeryDesignPatterns.Areas.Admin.CQRS.Commands.Product;
using BakeryDesignPatterns.DAL.Entities;
using BakeryDesignPatterns.DAL.Settings;
using MongoDB.Driver;

namespace BakeryDesignPatterns.Areas.Admin.CQRS.Handlers.ClientHandlers
{
    public class CreateClientQueryHandler
    {
        private readonly IMongoCollection<Client> _clientColleciton;
        private readonly IMapper _mapper;
        public CreateClientQueryHandler(IDatabaseSettings databaseSettings, IMapper mapper)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _clientColleciton = database.GetCollection<Client>(databaseSettings.ProductCollecitonName);
            _mapper = mapper;
        }

        public void Handle(CreateClientCommand command)
        {
            var value = new Client()
            {
               ImageUrl = command.ImageUrl,
               ClientName = command.ClientName,
               Title = command.Title
            };

            _clientColleciton.InsertOne(value);

        }
    }
}
