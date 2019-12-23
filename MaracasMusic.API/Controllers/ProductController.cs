﻿using System;
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
    public class ProductController : ControllerCrudBase<Product, ProductRepository>
    {
        private ProductRepository _productRepository;

        public ProductController(ProductRepository productRepository) : base(productRepository)

        { _productRepository = productRepository; }


        [HttpGet]
        [Route("basic")]

        public virtual async Task<IActionResult> GetBasic()

        {
            return Ok(await _productRepository.ListBasic());
        }

        //GET:api/Product/Detail/2
        [HttpGet]
        [Route("Detail/{Id}")]
        
        public virtual async Task<IActionResult> GetDetailById(int id)
        {
            return Ok(await _productRepository.GetDetailById(id));
        }

        [HttpGet]
        [Route("Detail/{TypeName}")]

        public virtual async Task<IActionResult> GetDetailByProductTypeName(string  typeName)
        {
            return Ok(await _productRepository.GetDetailByProductTypeName(typeName));
        }
    }
    
}