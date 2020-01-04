using Maracas.Lib.Models;
using MaracasMusic.API.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaracasMusic.API.Repositories
{
    public class ClientRepository : RepositoryBase<Client>
    {
        public ClientRepository( MaracasContext maracasContext ) : base(maracasContext)
        {



        }


        public async Task<Client> GetClientByEmail( string email )
        {
            return await _maracasContext.Clients

              .FirstOrDefaultAsync(c => c.Email == email);

        }

    }
}
