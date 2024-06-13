using Harcama.Business.Abstract;
using Harcama.DataAccess.Abstract;
using Harcama.DataAccess.Concrete.EntityFramework;
using Harcama.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.Business.Concrete
{
    public class KullaniciSirketleriManager : IKullaniciSirketleriServices
    {
        private readonly IKullaniciSirketleriRepository _kullaniciSirketleriRepository;

        public KullaniciSirketleriManager(IKullaniciSirketleriRepository kullaniciSirketleriRepository)
        {
            _kullaniciSirketleriRepository = kullaniciSirketleriRepository;
        }

        public async Task<bool> AddAsync(KullaniciSirketleri kullaniciSirketleri)
        {
            return await _kullaniciSirketleriRepository.AddAsync(kullaniciSirketleri);
        }

        public async Task<bool> AddRangeAsync(Guid userId, List<Guid> sirketIdList )
        {

            List<KullaniciSirketleri> kullaniciSirketleriList = new List<KullaniciSirketleri>();

            foreach (var sirketId in sirketIdList)
            {
                kullaniciSirketleriList.Add(new KullaniciSirketleri { UserId = userId, SirketId = sirketId });
            }

            await _kullaniciSirketleriRepository.AddRangeAsync(kullaniciSirketleriList);


            return true;



        }
        public IQueryable<KullaniciSirketleri> GetAll()
        {
            return _kullaniciSirketleriRepository.GetAll();
        }

        public Task<KullaniciSirketleri> GetById(string id)
        {
            return _kullaniciSirketleriRepository.GetSingleAsync(id);
        }



        public bool Remove(KullaniciSirketleri kullaniciSirketleri)
        {
            return _kullaniciSirketleriRepository.Remove(kullaniciSirketleri);
        }

        public async Task<bool> RemoveAsync(string id)
        {
            return await _kullaniciSirketleriRepository.RemoveAsync(id);
        }

        public Task<int> SaveAsync()
        {
            return _kullaniciSirketleriRepository.SaveAsync();
        }

        public bool Update(KullaniciSirketleri kullaniciSirketleri)
        {
            return _kullaniciSirketleriRepository.Update(kullaniciSirketleri);
        }

        
    }
}
