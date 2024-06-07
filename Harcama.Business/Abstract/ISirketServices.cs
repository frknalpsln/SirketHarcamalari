using Harcama.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.Business.Abstract
{
    public interface ISirketServices
    {
        IQueryable<Sirket> GetAll();

        Task<Sirket> GetById(string id);

        Task<bool> AddAsync(Sirket sirket);
        bool Remove(Sirket sirket);
        Task<bool> RemoveAsync(string id);
        bool Update(Sirket sirket);
        Task<int> SaveAsync();
    }
}
