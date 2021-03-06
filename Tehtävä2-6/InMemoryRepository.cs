using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Tehtävä2
{
    public class InMemoryRepository : iRepository
    {

        List<Player> playerList = new List<Player>();
        public async Task<Player> Create(Player player)
        {
            playerList.Add(player);
            return player;
        }

        public async Task<Player> Delete(Guid id)
        {

            Player found = null;

            foreach (Player p in playerList) {
                if (p.Id == id) {
                    found = p;
                    break;
                }
            }

            if (found != null) {
                playerList.Remove(found);
            }
            return found;

        }

        public async Task<Player> Get(Guid id)
        {
            Player found = null;
            foreach (Player p in playerList) {
                if (p.Id == id) {
                    found = p;
                    break;
                }
            }

            return found;
        }

        public async Task<Player> GetByName(string name)
        {
            return GetName(name);
        }

        public async Task<Player[]> GetAll()
        {
            return playerList.ToArray();
        }

        public async Task<Player> Modify(Guid id, ModifiedPlayer player)
        {
            Player found = null;

            foreach (Player p in playerList) {
                if (p.Id == id) {
                    found = p;
                    break;
                }
            }

            if (found != null) {
                found.Score = player.Score;
            }
            return found;
        }

        public async Task<Player> UpdatePlayerName(Guid id, UpdatedPlayerName player)
        {
            Player found = null;

            foreach (Player p in playerList) {
                if (p.Id == id) {
                    found = p;
                    break;
                }
            }

            if (found != null) {
                found.Name = player.UpdatedName;
            }
            return found;
        }

     private Item GetItemById(Guid playerid, Guid itemid) 
        {
            Player player = GetPlayerById(playerid);
            foreach (Item item in player.items)
            {
                if (item.Id == itemid)
                {
                    return item;
                }
            }
            return null;
        }
        private Player GetName(string name){
            foreach(Player player in playerList) {
                if (player.Name == name) {
                    return player;
                }
            }
            return null;
        }

        public async Task<Player[]> GetAllTags(string tag) {
           /* foreach (Player player in players) {
                if (player.Tag == tag) {
                    return player;
                }
            }
            return null;*/
            await Task.CompletedTask;
            return playerList.Where(x => x.Tag == tag).ToArray();
        }

        public async Task<Item> CreateItem(Guid playerid, Item item)
        {
            await Task.CompletedTask;
            Player player = GetPlayerById(playerid);
            player.items.Add(item);
            return item;
        }

        public async Task<Item> GetItem(Guid playerid, Guid itemid)
        {
            await Task.CompletedTask;
            Item item = GetItemById(playerid, itemid);
            return item;
        }

        public async Task<Item[]> GetAllItems(Guid playerid)
        {
            await Task.CompletedTask;
            Player player = GetPlayerById(playerid);
            return player.items.ToArray();
        }

        public async Task<Item> ModifyItem(Guid playerid, Guid itemid, ModifiedItem item)
        {
            await Task.CompletedTask;
            Item found = GetItemById(playerid, itemid);
            if (found != null)
            {
                found.Level = item.Level;
            }
            return found;
        }

        public async Task<Item> DeleteItem(Guid playerid, Guid itemid)
        {
            await Task.CompletedTask;
            Item found = GetItemById(playerid, itemid);
            Player player = GetPlayerById(playerid);
            if (found != null)
            {
                player.items.Remove(found);
                return found;
            }
            else
            {
                return null;
            }
        }
    }
}