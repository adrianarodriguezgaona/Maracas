using Maracas.Lib.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaracasMusic.API.Controllers
{
    public class ControllerCrudBase<T, R> : ControllerBase  
        where T : EntityBase
        where R : Repository<T>
 
    {
        protected R repository;

        public ControllerCrudBase(R r)
        {
            repository = r;
        }
    }
}
    