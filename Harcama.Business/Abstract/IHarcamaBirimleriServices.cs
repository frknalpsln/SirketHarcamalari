using Harcama.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.Business.Abstract
{
    public interface IHarcamaBirimleriServices
    {
        IQueryable<HarcamaBirimleri> GetAll();
        
       Task<bool> AddAsync(HarcamaBirimleri harcamaBirimleri);
        bool Remove(HarcamaBirimleri harcamaBirimleri);
        Task<bool> RemoveAsync(string id);
        bool Update(HarcamaBirimleri harcamaBirimleri);
    }
}
