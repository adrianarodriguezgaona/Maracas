using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaracasMusic.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaracasMusic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentController : ControllerBase
    {
        InstrumentRepository repository;

        public InstrumentController(InstrumentRepository instrumentRepository)
        {
            repository = instrumentRepository;
        }

        // api/instruments
        [HttpGet]
        public IActionResult GetScores()

        {
            return Ok(repository.List());
        }
    }
}