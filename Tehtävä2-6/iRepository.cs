using System;
using System.Threading.Tasks;

namespace Tehtävä2
{
    public interface iRepository
    {
        Task<Player> Get(Guid id);
        Task<Player> GetByName(string name);
        Task<Player[]> GetAll();
        Task<Player> Create(Player player);
        Task<Player> Modify(Guid id, ModifiedPlayer player);
        Task<Player> Delete(Guid id);
        Task<Player[]> GetAllTags(string tag);
        Task<Player[]> UpdatePlayerName(Guid id, UpdatedPlayerName uppdatedName);

        Task<Item> CreateItem(Guid playerId, Item item);
        Task<Item> GetItem(Guid playerId, Guid itemId);
        Task<Item[]> GetAllItems(Guid playerId);
        Task<Item> UpdateItem(Guid playerId, Guid itemId, ModifiedItem item);
        Task<Item> DeleteItem(Guid playerId, Guid itemId);
    }
}