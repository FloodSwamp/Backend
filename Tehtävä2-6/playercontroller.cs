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
        public Task<Player> Get(Guid id) {
            return pros.Get(id);
        }

        [HttpGet("{name}")]
        public Task<Player> GetName(string name){
            return pros.GetName(name);
        }

        [HttpGet]
        public Task<Player[]> GetAll(){
            return pros.GetAll();
        }

        [HttpGet("tag{tag}")]
        public Task<Player[]> GetAllTags(){
            return pros.GetAllTags();
        }

        [HttpPost]
        public Task<Player> Create([FromBody] newplayer player){
            return pros.Create(player);
        }
        [HttpPut("{id}")]
        public Task<Player> Modify(Guid id, [FromBody] ModifiedPlayer player){
            return pros.Modify(id, player);
        }

        [HttpDelete("{id}")]
        public Task<Player> Delete(Guid id){
            return pros.Delete(id);
        }

        [HttpPut("{id}/name")]
        public Task<Player> UpdateName(Guid id, [FromBody] UpdatedPlayerName player){
            return pros.UpdatePlayerName(id, player);
        }
    }
}