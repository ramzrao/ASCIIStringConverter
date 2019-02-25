using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASCIIStringConverter.Business;
using ASCIIStringConverter.Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASCIIStringConverter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        private IService<PersonVM> service;
        public PersonController(IService<PersonVM> service)
        {
            this.service = service;
        }
        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PersonVM person)
        {
            if (string.IsNullOrEmpty(person.FullName))
                return BadRequest();
            return Ok(await service.Handle(person));
        }

    }
}
