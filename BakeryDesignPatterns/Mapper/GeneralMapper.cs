using AutoMapper;
using BakeryDesignPatterns.Areas.Admin.CQRS.Commands.Product;
using BakeryDesignPatterns.Areas.Admin.CQRS.Results;
using BakeryDesignPatterns.DAL.Entities;

namespace BakeryDesignPatterns.Mapper
{
    public class GeneralMapper:Profile
    {
        public GeneralMapper()
        {
            CreateMap<Product, GetAllProductQueryResult>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();
            CreateMap<Product, GetProductByIdQueryResult>().ReverseMap();
        }
    }
}
