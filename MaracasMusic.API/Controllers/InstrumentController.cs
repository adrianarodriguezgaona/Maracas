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

        // api/instrument
        [HttpGet]
        public async Task <IActionResult> GetInstruments()

        {
            return Ok(await repository.ListAll());
        }

        //GET : api/Instrument/Basic

        [HttpGet]
        [Route ("Basic")]
        public async Task<IActionResult> GetInstrumentsBasic()
        {
            return Ok(await repository.ListBasic());
        }


        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetInstrumentDetail(int id)
        {
            return Ok(await repository.GetDetailById(id));
        }
    }
}