using Maracas.Lib.Models;
using MaracasMusic.API.Data;
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
            return _context.Instruments.ToList();
        }

         //  waiting for instrumentBasic DTO
        }

    }


}
