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
    public class InstrumentController : ControllerCrudBase<Instrument, InstrumentRepository>
    {
        private InstrumentRepository _instrumentRepository;

        public InstrumentController(InstrumentRepository instrumentRepository): base(instrumentRepository)
        {
            _instrumentRepository = instrumentRepository;
        }




        [HttpGet]
        [Route("basic")]

        public virtual async Task<IActionResult> GetBasic()

        {
            return Ok(await _instrumentRepository.ListBasic());
        }

        [HttpGet]
        [Route("{Id}")]

        public virtual async Task<IActionResult> GetDetailById(int id)
        {
            return Ok(await _instrumentRepository.GetDetailById(id));
        }
    }
}