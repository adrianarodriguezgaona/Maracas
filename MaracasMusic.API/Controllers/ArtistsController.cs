﻿using System;
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
    public class ArtistsController : ControllerBase
    {
        readonly ArtistRepository _artistRepository;

        public ArtistsController(ArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }

        // GET: api/Artists
        [HttpGet]
        public async Task<IActionResult> GetArtists()
        {
            return Ok(await _artistRepository.ListAll());
        }

        // GET: api/Artists/Basic
        [HttpGet]
        [Route("Basic")]
        public async Task<IActionResult> GetArtistBasic()
        {
            return Ok(await _artistRepository.ListBasic());
        }

        // GET: api/Artists/2
        [HttpGet("{id}")]
        public async Task<IActionResult> GetArtist(int id)
        {
            return Ok(await _artistRepository.GetById(id));
        }

        //PUT: api/Artists/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArtist([FromRoute] int id, [FromBody] Artist artist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != artist.Id)
            {
                return BadRequest();
            }

            Artist updatedArtist = await _artistRepository.Update(artist);
            if (updatedArtist == null)
            {
                return NotFound();
            }
            return Ok(updatedArtist);
        }
    }
}