using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tehtävä2
{

    [Route("api/[controller]")]
    [ApiController]
    public class playersController
    {

        public playersController(playerProcessor prossi) {
            pros = prossi;
        }

        playerProcessor pros;

        [HttpGet("{id}")]
        public Task<player> Get(Guid id) {
            return pros.Get(id);
        }

        [HttpGet]
        public Task<player[]> GetAll(){
            return pros.GetAll();
        }

        [HttpPost]
        public Task<player> Create([FromBody] newplayer player){
            return pros.Create(player);
        }
        [HttpPut("{id}")]
        public Task<player> Modify(Guid id, [FromBody] ModifiedPlayer player){
            return pros.Modify(id, player);
        }

        [HttpDelete("{id}")]
        public Task<player> Delete(Guid id){
            return pros.Delete(id);
        }
    }
}