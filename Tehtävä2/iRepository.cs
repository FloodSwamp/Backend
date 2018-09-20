using System;
using System.Threading.Tasks;

namespace Tehtävä2
{
    public interface iRepository
    {
        Task<player> Get(Guid id);
        Task<player[]> GetAll();
        Task<player> Create(player player);
        Task<player> Modify(Guid id, ModifiedPlayer player);
        Task<player> Delete(Guid id);

        Task<Item> CreateItem(Guid playerId, Item item);
        Task<Item> GetItem(Guid playerId, Guid itemId);
        Task<Item[]> GetAllItems(Guid playerId);
        Task<Item> UpdateItem(Guid playerId, Guid itemId, ModifiedItem item);
        Task<Item> DeleteItem(Guid playerId, Guid itemId);
    }
}