using Maracas.Lib.Models;
using MaracasMusic.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maracas.Lib.DTO;
using Microsoft.EntityFrameworkCore;

namespace MaracasMusic.API.Repositories
{
    public class ScoreRepository : RepositoryBase<Score>
    {
       
        
        public ScoreRepository(MaracasContext maracasContext) : base (maracasContext)
        {
           
        }


        public async Task<List<ScoreBasicDTO>> ListBasic()
        {
            return await _maracasContext.Scores.Select(s => new ScoreBasicDTO
            {
                Id = s.Id,
                Name = s.Name
            }).ToListAsync();
        }

        public async Task <ScoreDetail> GetDetailsById(int id)
        {
            return await _maracasContext.Scores.Select(s => new ScoreDetail
            {
                Id = s.Id,
                Name = s.Name,
                ProductId = s.Product.Id,
                Description = s.Product.Description,
                Foto = s.Product.Foto

            }).FirstOrDefaultAsync(s => s.Id == id);
                                
        }
    }
}
