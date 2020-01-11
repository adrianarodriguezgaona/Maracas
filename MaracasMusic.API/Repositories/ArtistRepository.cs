using AutoMapper;
using AutoMapper.QueryableExtensions;
using Maracas.Lib.DTO;
using Maracas.Lib.Models;
using MaracasMusic.API.Data;
using MaracasMusic.API.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaracasMusic.API.Repositories
{
    public class ArtistRepository : RepositoryMapping<Artist>
    {        
        public ArtistRepository(MaracasContext maracasContext, IMapper mapper) : base (maracasContext,mapper)
        {
            
        }

        public override async Task<Artist> GetById(int id)
        {
            return await _maracasContext.Artists                
                .Include(a => a.Genre)               
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<List<ArtistBasicDto>> ListBasic()
        {
            return await _maracasContext.Artists
              .ProjectTo<ArtistBasicDto>(_mapper.ConfigurationProvider)
              .ToListAsync();

        }
    }
}
