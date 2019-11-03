using Maracas.Lib.Models;
using MaracasMusic.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maracas.Lib.DTO;

namespace MaracasMusic.API.Repositories
{
    public class ScoreRepository
    {
        private MaracasContext _context;

        public ScoreRepository(MaracasContext context)
        {
            _context = context;
        }

        public List<Score> List()
        {
            return _context.Scores.ToList();
        }

        public List<ScoreBasicDTO> ListBasic()

            {
            return _context.Scores.Select(s => new ScoreBasicDTO
            {
                Id = s.Id,
                Name = s.Name

            }).ToList();
            }

    }
}
