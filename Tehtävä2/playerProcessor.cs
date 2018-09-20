using System;
using System.Threading.Tasks;

namespace Tehtävä2
{
    
    public class playerProcessor
    {

        public playerProcessor(iRepository reposi) {
            repo = reposi;
        }

        iRepository repo;
        public Task<player> Get(Guid id) {
            return repo.Get(id);
        }
        public Task<player[]> GetAll() {
            return repo.GetAll();
        }
        public Task<player> Create(newplayer player){
            player p = new player();
            p.Name = player.Name;
            p.Id = Guid.NewGuid();
            p.IsBanned = false;
            p.Score = 0; 
            p.CreationTime = DateTime.Now;
            return repo.Create(p);
        }
        public Task<player> Modify(Guid id, ModifiedPlayer player){
            return repo.Modify(id, player);
        }
        public Task<player> Delete(Guid id){
            return repo.Delete(id);
        }
    }
}