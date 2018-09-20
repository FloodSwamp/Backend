using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tehtävä2
{
    public class ItemsProcessor
    {
         public ItemsProcessor(iRepository reposi) {
            repo = reposi;
        }

        iRepository repo;
        public Task<Item> GetItem(Guid playerId, Guid id) {
            return repo.GetItem(playerId, id);
        }
        public Task<Item[]> GetAllItems(Guid playerId) {
            return repo.GetAllItems(playerId);
        }
        public Task<Item> CreateItem(Guid playerId, NewItem item){
            Item p = new Item();
            p.Name = item.Name;
            p.Id = Guid.NewGuid();
            p.IsBanned = false;
            p.Score = 0; 
            p.CreationTime = DateTime.Now;
            return repo.CreateItem(playerId, p);
        }
        public Task<Item> UpdateItem(Guid playerId, Guid id, ModifiedItem item){
            return repo.UpdateItem(playerId, id, item);
        }
        public Task<Item> DeleteItem(Guid playerId, Guid id){
            return repo.DeleteItem(playerId, id);
        }
    }
}