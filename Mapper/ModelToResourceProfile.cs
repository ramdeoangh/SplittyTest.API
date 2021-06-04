using AutoMapper;
using SplittyTest.API.Domain.Models;
using SplittyTest.API.Resources;
using SplittyTest.API.Extensions;

namespace SplittyTest.API.Mapper
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();
            CreateMap<RequestCategory, Category>();
           
        }
    }
}