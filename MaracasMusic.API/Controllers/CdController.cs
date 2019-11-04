using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaracasMusic.API.Data;
using MaracasMusic.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaracasMusic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CdController : ControllerBase
    {
        CdRepository _cdRepository;

        public CdController(CdRepository cdRepository)
        {
            _cdRepository = cdRepository;
        }

        [HttpGet]
        public IActionResult GetCds()
        {
            return Ok(_cdRepository.List());
        }

        [HttpGet]
        [Route("Basic")]
        public IActionResult GetCdsBasic()
        {
            return Ok(_cdRepository.ListBasic());
        }
    }
}