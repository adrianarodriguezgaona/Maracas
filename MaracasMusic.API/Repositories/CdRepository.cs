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
    public class CdRepository : RepositoryBase<Cd>
    {
      
        public CdRepository( MaracasContext maracasContext) : base (maracasContext)
        {
           
        }
        public async Task<List <CdBasicDto>> ListBasic()
        {
            return  await _maracasContext.Cds.Select(cd => new CdBasicDto
            {
                Id = cd.Id,
                Name = cd.Name
            }).ToListAsync();
                
        }

        public async Task<CdDetail> GetDetailById(int id)
        {
            return (
                 await _maracasContext.Cds              
                .Select(cd => new CdDetail
                {
                    Id = cd.Id,
                    Name = cd.Name,
                    ProductId = cd.Product.Id,
                    ProductPrice = cd.Product.Price,
                    CdDescription = cd.Product.Description,
                    CdFoto = cd.Product.Foto,
                    ArtistId = cd.Artist.Id,
                    ArtistName = cd.Artist.Name,
                    GenreId = cd.Genre.Id,
                    GenreName = cd.Genre.Name
                 })               
                .FirstOrDefaultAsync(cd => cd.Id == id));
        }
      

    }
}
