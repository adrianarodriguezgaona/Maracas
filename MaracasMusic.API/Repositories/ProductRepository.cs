﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using Maracas.Lib.DTO;
using Maracas.Lib.Models;
using MaracasMusic.API.Data;
using MaracasMusic.API.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaracasMusic.API.Repositories
{
    public class ProductRepository : RepositoryMapping<Product>
    {
        public ProductRepository(MaracasContext maracasContext, IMapper mapper) : base (maracasContext, mapper)
        {

        }

        public override async Task<Product> GetById(int id)
        {
            return await _maracasContext.Products
                .Include(p => p.Artist)
                .Include(p => p.Genre)
                .Include(p => p.InstrumentType)
                .Include(p => p.ProductType)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<ProductBasicDto>> ListBasic()
        {
            return await _maracasContext.Products
              .ProjectTo<ProductBasicDto>(_mapper.ConfigurationProvider)
              .OrderBy(p => p.Name)
              .ToListAsync();

        }

        public async Task<ProductDetail> GetDetailById(int id)
        {
            return _mapper.Map<ProductDetail>(
                 await _maracasContext.Products
                                      .Include(p => p.Artist)
                                      .Include(p => p.Genre)
                                      .Include(p => p.InstrumentType)
                                      .Include(p => p.ProductType)
                                      .FirstOrDefaultAsync(p => p.Id == id));
        }

        public async Task<List<ProductDetail>> GetDetailByProductTypeName(string typeName)
        {
            return  await _maracasContext.Products
                                      .Include(p => p.Artist)
                                      .Include(p => p.Genre)
                                      .Include(p => p.InstrumentType)
                                      .Include(p => p.ProductType)
                                      .Where(p => p.ProductType.Name == typeName)
                                      .ProjectTo<ProductDetail>(_mapper.ConfigurationProvider)
                                      .ToListAsync();
        }


    }
}
