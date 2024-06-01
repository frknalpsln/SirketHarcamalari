using Harcama.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.Business.Abstract
{
    public interface IKullaniciServices
    {
        IQueryable<Kullanici> GetAll();

        Task<bool> AddAsync(Kullanici kullanici);
        bool Remove(Kullanici kullanici);
        Task<bool> RemoveAsync(string id);
        bool Update(Kullanici kullanici);
    }
}
