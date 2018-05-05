using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;
using Grains.GrainsContracts;
using Microsoft.AspNetCore.Mvc;
using Orleans;

namespace ApiClient.Controllers
{
    [Route("api/[controller]")]
    public class BoardController : Controller
    {
        private IClusterClient _client; 
        public BoardController(IClusterClient client)
        {
            _client = client;
        }

        // GET api/Board
        [HttpGet]
        public async Task<IList<Board>> Get()
        {
            var list= await _client.GetGrain<IBoardGrain>(Guid.Empty).GetAllBoards();
            return list;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
