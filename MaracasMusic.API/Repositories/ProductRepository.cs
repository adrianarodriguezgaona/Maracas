using Maracas.Lib.Models;
using MaracasMusic.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaracasMusic.API.Repositories
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(MaracasContext maracasContext) : base (maracasContext)
        {

        }
    }
}
