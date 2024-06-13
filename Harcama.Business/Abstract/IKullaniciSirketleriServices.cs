using Harcama.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.Business.Abstract
{
    public interface IKullaniciSirketleriServices
    {
        IQueryable<KullaniciSirketleri> GetAll();

        Task<KullaniciSirketleri> GetById(string id);

        Task<bool> AddRangeAsync(Guid userId, List<Guid> sirketIdList);
        Task<bool> AddAsync(KullaniciSirketleri kullaniciSirketleri);
        bool Remove(KullaniciSirketleri kullaniciSirketleri);
        Task<bool> RemoveAsync(string id);
        bool Update(KullaniciSirketleri kullaniciSirketleri);
        Task<int> SaveAsync();

    }
}
