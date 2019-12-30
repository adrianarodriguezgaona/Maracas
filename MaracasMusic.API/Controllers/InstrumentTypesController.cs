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
    public class InstrumentTypesController : ControllerCrudBase<InstrumentType, InstrumentTypeRepository>
    {
        public InstrumentTypesController(InstrumentTypeRepository instrumentRepository) : base(instrumentRepository)
        {
                
        }
    }
    
}