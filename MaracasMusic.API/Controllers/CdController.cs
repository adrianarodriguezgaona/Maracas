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

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetCdDetail(int id)
        {
            return Ok(_cdRepository.GetDetailById(id));
        }

        [HttpGet]
        [Route("ImageByName/{filename}")]
        public IActionResult GetImageByFileName(string filename)
        {
            var pathOfImage = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", filename);
            return PhysicalFile(pathOfImage, "image/jpeg");
        }

        // GET: api/cd/imagebyid/6
        [HttpGet]
        [Route("ImageById/{cdid}")]
        public IActionResult GetImageByBookId(int cdId)
        {
            return GetImageByFileName(_cdRepository.GetDetailById(cdId).CdFoto);
        }

        ////PUT: api/Cd/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCd ([FromRoute] int id, [FromBody] Cd cd)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    if (id != cd.Id)
        //    {
        //        return BadRequest();
        //    }

        //    Cd updatedCd = await _cdRepository.Update(cd);
        //    if (updatedCd == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(updatedCd);
        //}
    }
}