﻿using Maracas.Lib.DTO;
using Maracas.Lib.Models;
using MaracasMusic.API.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaracasMusic.API.Repositories
{
    public class CdRepository
    {
        private MaracasContext _maracasContext;

        public CdRepository( MaracasContext maracasContext)
        {
            _maracasContext = maracasContext;
        }

        public List <Cd> List()
        {
            return _maracasContext.Cds.ToList();
        }

        public List <CdBasicDto> ListBasic()
        {
            return _maracasContext.Cds.Select(cd => new CdBasicDto
            {
                Id = cd.Id,
                Name = cd.Name
            }).ToList();
                
        }

        public CdDetail GetDetailById(int id)
        {
            return (
                 _maracasContext.Cds
                .Include(cd => cd.Product)
                .Include(cd => cd.Artist)
                .Include(cd => cd.Genre)
                .Select(cd => new CdDetail
                {
                    Id = cd.Id,
                    Name = cd.Name,
                    ProductId = cd.Product.Id,
                    ProductPrice = cd.Product.Price,
                    CdDescription = cd.Product.Description,
                    CdFoto = cd.Product.Foto,
                    ArtistId = cd.Artist.Id,
                    ArtistName = cd.Artist.Name,
                     GenreId = cd.Genre.Id,
                     GenreName = cd.Genre.Name
                 })               
                .FirstOrDefault(cd => cd.Id == id));
        }

        //public async Task<Cd>Update (Cd cd)
        //{
        //    try
        //    {
        //        _maracasContext.Entry(cd).State = EntityState.Modified;
        //        await _maracasContext.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CdExists(cd.Id))
        //        {
        //            return null;
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }
        //    return cd;
        //}

        //private bool CdExists(int id)
        //{
        //    return _maracasContext.Cds.Any(e => e.Id == id);
        //}


    }
}
