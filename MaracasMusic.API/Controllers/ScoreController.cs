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
    public class ScoreController : ControllerBase
    {
        ScoreRepository repository;

        public ScoreController(ScoreRepository scoreRepository)
        {
            repository = scoreRepository;
        }

        // GET api/scores

        [HttpGet]
        public IActionResult GetScores()

        {
            return Ok(repository.ListAll());
        }

        [HttpGet]
        [Route("basic")]
        public IActionResult GetScoresBasic()
        {
            return Ok(repository.ListBasic());
        }


        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetScoreDetailById(int id)

        {
            return Ok(repository.GetDetailsById(id));   
        }
    }
}