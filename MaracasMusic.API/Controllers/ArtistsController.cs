using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maracas.Lib.Models;
using MaracasMusic.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaracasMusic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerCrudBase<Artist, ArtistRepository>
    {
      
        public ArtistsController(ArtistRepository artistRepository) : base(artistRepository)
        {
           
        }

        [HttpPost]
        public override async Task<IActionResult> Post([FromBody] Artist artist)
        {           
            artist.Genre = null;

            return await base.Post(artist);
        }


    }
}