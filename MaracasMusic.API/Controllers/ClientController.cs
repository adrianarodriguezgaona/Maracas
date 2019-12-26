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
    public class ClientController : ControllerCrudBase<Client, ClientRepository>
    {
        private ClientRepository _clientRepository;
        public ClientController( ClientRepository clientRepository ) : base(clientRepository)
        {


        }
        [HttpGet]
        [Route("clientById/{Id}")]

        public virtual async Task<IActionResult> getById( int Id )

        {
            return Ok(await _clientRepository.GetById(Id));
        }

        [HttpGet]
        [Route("clientById/{Id}")]



        [HttpPost]
        public virtual async Task<IActionResult> AddClient( Client client )

        {
            return Ok(await _clientRepository.Add(client));
        }

        [HttpDelete]
        [Route("{Id}")]

        public virtual async Task<IActionResult> DeleteClient( Client client )

        {
            return Ok(await _clientRepository.Delete(client));
        }


    }
}