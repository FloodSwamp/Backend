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
        public Task<Player> Get(Guid id) {
            return repo.Get(id);
        }

        public Task<player> GetName(string namr) {
            return repo.GetByName(name);
        }

        public Task<Player[]> GetAll() {
            return repo.GetAll();
        }

        public Task<Player[]> GetTags(string tag) {
            return repo.GetAllTags(tag);
        }
        public Task<Player> Create(newplayer player){
            Player p = new Player();
            p.Name = player.Name;
            p.Id = Guid.NewGuid();
            p.IsBanned = false;
            p.Score = 0; 
            p.CreationTime = DateTime.Now;
            p.Tag = player.Tag;
            return repo.Create(p);
        }
        public Task<Player> Modify(Guid id, ModifiedPlayer player){
            return repo.Modify(id, player);
        }

        public Task<Player> UpdateName (Guid id, UpdatedPlayerName player){
            return repo.UpdatePlayerName(id, player);
        }
        public Task<Player> Delete(Guid id){
            return repo.Delete(id);
        }
    }
}