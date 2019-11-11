using Maracas.Lib.Models;
using MaracasMusic.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaracasMusic.API.Controllers
{
    public class ControllerCrudBase<T, R> : ControllerBase
        where T : EntityBase
        where R : RepositoryBase<T>

    {
        protected R repository;

        public ControllerCrudBase(R r)
        {
            repository = r;
        }

        // get API/T
        [HttpGet]
        public virtual async Task<IActionResult> Get()  // virtual => kan overriden worden door klasse die ervan overerft
        {
            return Ok(await repository.ListAll());
        }


        // get API/T/Id
        [HttpGet]
        [Route("{Id}")]

        public virtual async Task<IActionResult> GetById(int id)
        {
            return Ok(await repository.GetById(id));
        }

        // Put API/T/Id
        [HttpPut]
        [Route("{Id}")]
        public virtual async Task<IActionResult> Put([FromRoute] int id, [FromBody] T entity)

        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }



            if (id != entity.Id)
            {
                return BadRequest();

            }

            T entUpdate = await repository.Update(entity);
            if (entUpdate == null)
            {
                return NotFound();
            }

            return Ok(entUpdate);
        }

        // Post API/T
        [HttpPost]
        public virtual async Task<IActionResult> Post([FromBody] T entity)

        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            T entPost = await repository.Add(entity);

            if (entPost == null)
            {
                return NotFound();
            }

            return CreatedAtAction("Get", new { Id = entity.Id }, entity);

        }


        // Delete API/T/Id
        [HttpPost("{Id}")]
        public virtual async Task<IActionResult> Delete([FromBody] T entity, [FromRoute] int Id)

        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            T entDelete = await repository.Delete(Id);

            if (entDelete == null)
            {
                return NotFound();
            }

            return Ok(entity);

        }





    }
}
    