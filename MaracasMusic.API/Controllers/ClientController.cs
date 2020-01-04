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

            _clientRepository = clientRepository;

        }


        [HttpGet]
        [Route("GetByEmail/{Email}")]


        public virtual async Task<IActionResult> GetByClientEmail( string email )

        {
            return Ok(await _clientRepository.GetClientByEmail(email));
        }
    }
}