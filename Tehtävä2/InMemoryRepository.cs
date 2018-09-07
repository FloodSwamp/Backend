using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Tehtävä2
{
    public class InMemoryRepository : iRepository
    {

        List<player> playerList = new List<player>();
        public async Task<player> Create(player player)
        {
            playerList.Add(player);
            return player;
        }

        public async Task<player> Delete(Guid id)
        {

            player found = null;

            foreach (player p in playerList) {
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

        public async Task<player> Get(Guid id)
        {
            player found = null;

            foreach (player p in playerList) {
                if (p.Id == id) {
                    found = p;
                    break;
                }
            }

            return found;

        }

        public async Task<player[]> GetAll()
        {

            return playerList.ToArray();

        }

        public async Task<player> Modify(Guid id, ModifiedPlayer player)
        {
            player found = null;

            foreach (player p in playerList) {
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
    }
}