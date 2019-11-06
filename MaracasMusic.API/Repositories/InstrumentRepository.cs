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
    public class InstrumentRepository
    {
        private MaracasContext _context;

        public InstrumentRepository( MaracasContext context)
        {
            _context = context;
        }

        public List<Instrument> List()
        {
            return _context.Instruments
                .Include(i => i.Product)
                .ToList();
        }

        public List<InstrumentBasicDto> ListBasic ()
        {
            return _context.Instruments.Select(i => new InstrumentBasicDto
            {
                Id = i.Id,
                Name = i.Name
            }).ToList();
        }

        public InstrumentDetail GetDetailById(int id)
        {
            return (
                 _context.Instruments.Select(i => new InstrumentDetail
                 {
                     Id = i.Id,
                     Name = i.Name,
                     ProductId = i.Product.Id,
                     ProductPrice = i.Product.Price,
                     Description = i.Product.Description,
                     Foto = i.Product.Foto

                 })
                .FirstOrDefault(i => i.Id == id));
        }


    }

}
