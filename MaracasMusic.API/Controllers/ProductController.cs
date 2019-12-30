using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Maracas.Lib.Models;
using MaracasMusic.API.Data;
using MaracasMusic.API.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;

namespace MaracasMusic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerCrudBase<Product, ProductRepository>
    {
        private ProductRepository _productRepository;
        private readonly IHostingEnvironment _hostingEnvironment;

        public ProductController(ProductRepository productRepository, IHostingEnvironment hostingEnvironment) : base(productRepository)

        { _productRepository = productRepository; _hostingEnvironment = hostingEnvironment;
        }


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
        [Route("DetailByType/{TypeName}")]

        public virtual async Task<IActionResult> GetDetailByProductTypeName(string typeName)
        {
            return Ok(await _productRepository.GetDetailByProductTypeName(typeName));
        }

        // GET: api/product/imagebyname/shakira.jpg
        [HttpGet]
        [Route("ImageByName/{filename}")]
        public IActionResult GetImageByFileName(string filename)
        {
            var pathOfImage = Path.Combine(_hostingEnvironment.WebRootPath, "images", filename);
            return PhysicalFile(pathOfImage, "image/jpeg");
        }

        // GET: api/product/imagebyid/6
        [HttpGet]
        [Route("ImageById/{productid}")]
        public async Task<IActionResult> GetImageById(int productId)
        {
            ProductDetail product = await repository.GetDetailById(productId);
            return GetImageByFileName(product.Foto);
        }

        [HttpPost]
        public override async Task<IActionResult> Post([FromBody] Product product)
        {
            product.Artist = null;
            product.ProductType = null;
            product.InstrumentType = null;
            product.Genre = null;

            return await base.Post(product);
        }


        [HttpPost]
        [Route("Image")]

        public async Task<IActionResult> Image( IFormFile formFile )

        {

            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images" , formFile.FileName);

            if (formFile.Length > 0)

            {
              using (var stream = new FileStream(filePath, FileMode.Create))

                {
                    await formFile.CopyToAsync(stream);
                }
            }

            return Ok(new
            {
                count = 1,
                formFile.Length
            }
            );
        }
    }
    
}