using Maracas.Lib.Models;
using MaracasMusic.API.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaracasMusic.API.Repositories
{
    public class GenreRepository : RepositoryBase<Genre>
    {
        public GenreRepository(MaracasContext maracasContext) : base(maracasContext)
        {
           
        }
       
    }
}
