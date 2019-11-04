using Maracas.Lib.DTO;
using Maracas.Lib.Models;
using MaracasMusic.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaracasMusic.API.Repositories
{
    public class CdRepository
    {
        private MaracasContext _maracasContext;

        public CdRepository( MaracasContext maracasContext)
        {
            _maracasContext = maracasContext;
        }

        public List <Cd> List()
        {
            return _maracasContext.Cds.ToList();
        }

        public List <CdBasicDto> ListBasic()
        {
            return _maracasContext.Cds.Select(cd => new CdBasicDto
            {
                Id = cd.Id,
                Name = cd.Name
            }).ToList();
                
        }

    }
}
