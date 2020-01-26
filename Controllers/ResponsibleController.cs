using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ResponsibleController : ControllerBase
    {
      
            private readonly CoopMISConText _coopMISConText;

        public ResponsibleController(CoopMISConText coopMISConText)
            {
                _coopMISConText = coopMISConText;
            }
            // GET api/values
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Data.ResponsibleName>>> GetResponsibleName()
            {
            return await _coopMISConText.responsibleName.ToListAsync();
            }

        
    }
}