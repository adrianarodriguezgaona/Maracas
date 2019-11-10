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
    public class InstrumentRepository : RepositoryBase<Instrument>
    {
       
        public InstrumentRepository( MaracasContext maracasContext) : base (maracasContext)
        {
          
        }

       
        public async Task<List<InstrumentBasicDto>> ListBasic ()
        {
            return await _maracasContext.Instruments.Select(i => new InstrumentBasicDto
            {
                Id = i.Id,
                Name = i.Name
            }).ToListAsync();
        }

        public async Task<InstrumentDetail> GetDetailById(int id)
        {
            return (
                await  _maracasContext.Instruments.Select(i => new InstrumentDetail
                 {
                     Id = i.Id,
                     Name = i.Name,
                     ProductId = i.Product.Id,
                     ProductPrice = i.Product.Price,
                     Description = i.Product.Description,
                     Foto = i.Product.Foto

                 })
                .FirstOrDefaultAsync(i => i.Id == id));
        }


    }

}
