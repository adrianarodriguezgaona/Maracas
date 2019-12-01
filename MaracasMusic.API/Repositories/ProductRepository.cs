using Maracas.Lib.DTO;
using Maracas.Lib.Models;
using MaracasMusic.API.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaracasMusic.API.Repositories
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(MaracasContext maracasContext) : base (maracasContext)
        {

        }

        public async Task<List<ProductBasicDto>> ListBasic()
        {
            return await _maracasContext.Products.Select(p => new ProductBasicDto
            {
                Id = p.Id,
                Name = p.Name
            }).ToListAsync();

        }

        public async Task<ProductDetail> GetDetailById(int id)
        {
            return (
                 await _maracasContext.Cds
                .Select(p => new ProductDetail
                {
                    Id = p.Id,
                    Name = p.Name,                    
                    Price = p.Price,
                    Description = p.Description,
                    Foto = p.Foto,
                    ArtistId = p.Artist.Id,
                    ArtistName = p.Artist.Name,
                    GenreId = p.Genre.Id,
                    GenreName = p.Genre.Name,
                    InstrumentTypeId=p.InstrumentType.Id,
                    InstrumentTypeName =p.InstrumentType.Name
                })
                .FirstOrDefaultAsync(p => p.Id == id));
        }

        public async Task<ProductDetail> GetDetailByProductTypeName(string typeName)
        {
            return (
                 await _maracasContext.Cds
                .Select(p => new ProductDetail
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    Foto = p.Foto,
                    ArtistId = p.Artist.Id,
                    ArtistName = p.Artist.Name,
                    GenreId = p.Genre.Id,
                    GenreName = p.Genre.Name,
                    InstrumentTypeId = p.InstrumentType.Id,
                    InstrumentTypeName = p.InstrumentType.Name,
                    ProductTypeId= p.ProducType.Id,
                    ProductTypeName = p.ProductType.Name

                })
                .FirstOrDefaultAsync(pd => pd.ProductTypeName == typeName));
        }

    }
}
