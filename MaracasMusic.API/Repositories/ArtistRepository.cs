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
    public class ArtistRepository : RepositoryBase<Artist>
    {        
        public ArtistRepository(MaracasContext maracasContext) : base (maracasContext)
        {
            
        }

        public async Task<List<ArtistBasicDto>> ListBasic()
        {
            return await _maracasContext.Artists.Select(a => new ArtistBasicDto
            {
                Id = a.Id,
                Name = a.Name
            }).ToListAsync();

        }
    }
}
