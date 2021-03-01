﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OG.Domain.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OG.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BidController : ControllerBase
    {
        // GET: api/<BidController>
        [HttpGet]
        public IEnumerable<string> Get(BidRequestDTO bid)
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BidController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BidController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BidController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BidController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
