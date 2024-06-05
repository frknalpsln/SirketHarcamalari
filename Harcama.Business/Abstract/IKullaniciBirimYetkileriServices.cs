using Harcama.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.Business.Abstract
{
    public interface IKullaniciBirimYetkileriServices
    {
        IQueryable<KullaniciBirimYetkileri> GetAll();

        Task<bool> AddAsync(KullaniciBirimYetkileri kullaniciBirimYetkileri);
        bool Remove(KullaniciBirimYetkileri kullaniciBirimYetkileri);
        Task<bool> RemoveAsync(string id);
        bool Update(KullaniciBirimYetkileri kullaniciBirimYetkileri);
    }
}
