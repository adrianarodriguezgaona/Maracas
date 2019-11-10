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
    public class GenresController : ControllerBase
    {
        readonly GenreRepository _genreRepository;

        public GenresController(GenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        // GET: api/Genres
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public IActionResult GetGenres()
        {
            return Ok(_genreRepository.ListAll());
        }

        // GET: api/Genres/2
        [HttpGet("{id}")]
        public IActionResult GetGenre(int id)
        {
            return Ok(_genreRepository.GetById(id));
        }

        //PUT: api/Genres/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGenre([FromRoute] int id, [FromBody] Genre genre)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != genre.Id)
            {
                return BadRequest();
            }

            Genre updatedGenre = await _genreRepository.Update(genre);
            if (updatedGenre == null)
            {
                return NotFound();
            }
            return Ok(updatedGenre);
        }

        //POST: api/genres
        [HttpPost]
        public async Task<IActionResult> PostGenre([FromBody] Genre genre)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _genreRepository.Add(genre);

            return CreatedAtAction(nameof(GetGenre), new { id = genre.Id }, genre);
        }

        //Delete: apio/genres/2
        [HttpDelete("{id}")]
        public async Task <IActionResult> DeleteGenre([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var genre = await _genreRepository.Delete(id);
            if (genre == null)
            {
                return NotFound();
            }
            return Ok(genre);
        }
    }
}