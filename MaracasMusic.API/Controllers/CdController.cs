using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Maracas.Lib.Models;
using MaracasMusic.API.Data;
using MaracasMusic.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaracasMusic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CdController : ControllerCrudBase<Cd, CdRepository>
    {
        private CdRepository _cdRepository;

        public CdController(CdRepository cdRepository) : base(cdRepository)

        { _cdRepository = cdRepository; }


        [HttpGet]
        [Route("basic")]

        public virtual async Task<IActionResult> GetBasic()

        {
            return Ok(await _cdRepository.ListBasic());
        }

        [HttpGet]
        [Route("{Id}")]
        
        public virtual async Task<IActionResult> GetDetailById(int id)
        {
            return Ok(await _cdRepository.GetDetailById(id));
        }
    }
    
}