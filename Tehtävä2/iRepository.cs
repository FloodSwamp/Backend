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
    }
}