namespace Tehtävä2
{

    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController
    {
       public ItemsController(ItemsController prossi) {
            pros = prossi;
        }

        ItemsProcessor pros;

        [HttpGet("{id}")]
        public Task<Item> Get(Guid playerId,Guid id) {
            return pros.Get(playerId, id);
        }

        [HttpGet]
        public Task<Item[]> GetAll(Guid playerId){
            return pros.GetAll(playerId);
        }

        [HttpPost]
        [Catch]
        public Task<Item> Create(Guid playerId, [FromBody] NewItem item){
            return pros.Create(playerId, item);
        }
        [HttpPut("{id}")]
        public Task<Item> Modify(Guid playerId, Guid id, [FromBody] ModifiedItem item){
            return pros.Modify(playerId, id, item);
        }

        [HttpDelete("{id}")]
        public Task<Item> Delete(Guid playerId, Guid id){
            return pros.Delete(playerId, id);
        } 
    }
}