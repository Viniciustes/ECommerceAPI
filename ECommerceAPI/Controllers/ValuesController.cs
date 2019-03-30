﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [Route("ECommerceAPI/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // DELETE api/values/5
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
       
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
