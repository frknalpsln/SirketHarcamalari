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

        Task<KullaniciBirimYetkileri> GetById(string id);
        Task<bool> AddRangeAsync(Guid userId, List<Guid> birimIdList);

        Task<bool> AddAsync(KullaniciBirimYetkileri kullaniciBirimYetkileri);
        bool Remove(KullaniciBirimYetkileri kullaniciBirimYetkileri);
        Task<bool> RemoveAsync(string id);
        bool Update(KullaniciBirimYetkileri kullaniciBirimYetkileri);
        Task<int> SaveAsync();

    }
}
