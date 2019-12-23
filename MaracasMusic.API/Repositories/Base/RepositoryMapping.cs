using AutoMapper;
using Maracas.Lib.Models;
using MaracasMusic.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaracasMusic.API.Repositories.Base
{
    public class RepositoryMapping<T> : RepositoryBase<T> where T: EntityBase
    {
        protected readonly IMapper _mapper;
        
        public RepositoryMapping(MaracasContext maracasContext, IMapper mapper) : base(maracasContext)
        {
            _mapper = mapper;
        }
    }
}
