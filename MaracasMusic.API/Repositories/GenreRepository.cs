using Maracas.Lib.Models;
using MaracasMusic.API.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaracasMusic.API.Repositories
{
    public class GenreRepository
    {
        private MaracasContext _maracasContext;

        public GenreRepository(MaracasContext maracasContext)
        {
            _maracasContext = maracasContext;
        }
        public List <Genre> List()
        {
            return _maracasContext.Genres.ToList();
        }

        public Genre GetById(int id)
        {
            return _maracasContext.Genres.Find(id);
        }

        public async Task<Genre> Update(Genre genre)
        {
            try
            {
                _maracasContext.Entry(genre).State = EntityState.Modified;
                await _maracasContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GenreExists(genre.Id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
            return genre;
        }

        public async Task<Genre> Add (Genre genre)
        {
            _maracasContext.Genres.Add(genre);
            await _maracasContext.SaveChangesAsync();
            return genre;
        }

        public async Task<Genre> Delete(int id)
        {
            var genre = await _maracasContext.Genres.FindAsync(id);
            if(genre == null)
            {
                return null;
            }
            _maracasContext.Genres.Remove(genre);
            await _maracasContext.SaveChangesAsync();
            return genre;
        }

        private bool GenreExists(int id)
        {
            return _maracasContext.Cds.Any(g => g.Id == id);
        }
    }
}
