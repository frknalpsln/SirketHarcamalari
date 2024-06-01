using Harcama.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.Business.Abstract
{
    public interface IProjeTanimlariServices
    {
        IQueryable<ProjeTanimlari> GetAll();

        Task<bool> AddAsync(ProjeTanimlari projeTanimlari);
        bool Remove(ProjeTanimlari projeTanimlari);
        Task<bool> RemoveAsync(string id);
        bool Update(ProjeTanimlari projeTanimlari);
    }
}
