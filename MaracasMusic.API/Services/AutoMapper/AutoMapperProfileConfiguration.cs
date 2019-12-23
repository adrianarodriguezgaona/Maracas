using AutoMapper;
using Maracas.Lib.DTO;
using Maracas.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaracasMusic.API.Services.AutoMapper
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration(): this ("MyProfile")
        {

        }

        public AutoMapperProfileConfiguration(string profileName) : base(profileName)
        {
            CreateMap<ProductBasicDto, Product>().ReverseMap();
            CreateMap<ArtistBasicDto, Artist>().ReverseMap();
            CreateMap<Product, ProductDetail>().ReverseMap();

        }
    }
}
