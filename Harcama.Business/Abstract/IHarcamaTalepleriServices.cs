using Harcama.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.Business.Abstract
{
    public interface IHarcamaTalepleriServices
    {
        IQueryable<HarcamaTalepleri> GetAll();

        Task<HarcamaTalepleri> GetById(string id);

        Task<bool> AddAsync(HarcamaTalepleri harcamaTalepleri);
        bool Remove(HarcamaTalepleri harcamaTalepleri);
        Task<bool> RemoveAsync(string id);
        bool Update(HarcamaTalepleri harcamaTalepleri);
        Task<int> SaveAsync();

    }

}
