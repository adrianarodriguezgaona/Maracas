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
    public class ScoreController : ControllerCrudBase<Score, ScoreRepository>
    {
       private ScoreRepository _scoreRepository;

        public ScoreController(ScoreRepository scoreRepository) : base(scoreRepository)
        {
            _scoreRepository = scoreRepository;
        }



        [HttpGet]
        [Route("basic")]

        public virtual async Task<IActionResult> GetBasic()

        {
            return Ok(await _scoreRepository.ListBasic());
        }

        [HttpGet]
        [Route("{Id}")]

        public virtual async Task<IActionResult> GetDetailById(int id)
        {
            return Ok(await _scoreRepository.GetDetailsById(id));
        }
    }
}