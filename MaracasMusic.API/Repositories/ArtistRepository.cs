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
    public class ArtistRepository
    {
        private MaracasContext _maracasContext;

        public ArtistRepository(MaracasContext maracasContext)
        {
            _maracasContext = maracasContext;
        }
        public List<Artist> List()
        {
            return _maracasContext.Artists.ToList();
        }

        public List<ArtistBasicDto> ListBasic()
        {
            return _maracasContext.Artists.Select(a => new ArtistBasicDto
            {
                Id = a.Id,
                Name = a.Name
            }).ToList();
        }

        public Artist GetById(int id)
        {
            return _maracasContext.Artists.Find(id);
        }

        public async Task<Artist> Update(Artist artist)
        {
            try
            {
                _maracasContext.Entry(artist).State = EntityState.Modified;
                await _maracasContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtistExists(artist.Id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
            return artist;
        }

        private bool ArtistExists(int id)
        {
            return _maracasContext.Cds.Any(e => e.Id == id);
        }

    }
}
