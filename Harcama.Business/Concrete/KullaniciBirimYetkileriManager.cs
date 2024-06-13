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
    public class KullaniciBirimYetkileriManager : IKullaniciBirimYetkileriServices
    {
        private readonly IKullaniciBirimYetkileriRepository _kullaniciBirimYetkileriRepository;

        public KullaniciBirimYetkileriManager(IKullaniciBirimYetkileriRepository kullaniciBirimYetkileriRepository)
        {
            _kullaniciBirimYetkileriRepository = kullaniciBirimYetkileriRepository;
        }

        public async Task<bool> AddAsync(KullaniciBirimYetkileri kullaniciBirimYetkileri)
        {
            return await _kullaniciBirimYetkileriRepository.AddAsync(kullaniciBirimYetkileri);
        }


        public async Task<bool> AddRangeAsync(Guid userId, List<Guid> birimIdList)
        {

            List<KullaniciBirimYetkileri> kullaniciBirimYetkileri = new List<KullaniciBirimYetkileri>();

            foreach (var birimId in birimIdList)
            {
                kullaniciBirimYetkileri.Add(new KullaniciBirimYetkileri { UserId = userId, BirimId = birimId });
            }

            await _kullaniciBirimYetkileriRepository.AddRangeAsync(kullaniciBirimYetkileri);


            return true;
        }

        public IQueryable<KullaniciBirimYetkileri> GetAll()
        {
            return _kullaniciBirimYetkileriRepository.GetAll();
        }

        public Task<KullaniciBirimYetkileri> GetById(string id)
        {
            return _kullaniciBirimYetkileriRepository.GetSingleAsync(id);
        }

        public bool Remove(KullaniciBirimYetkileri kullaniciBirimYetkileri)
        {
            return _kullaniciBirimYetkileriRepository.Remove(kullaniciBirimYetkileri);
        }

        public async Task<bool> RemoveAsync(string id)
        {
            return await _kullaniciBirimYetkileriRepository.RemoveAsync(id);
        }

        public Task<int> SaveAsync()
        {
            return _kullaniciBirimYetkileriRepository.SaveAsync();
        }

        public bool Update(KullaniciBirimYetkileri kullaniciBirimYetkileri)
        {
            return _kullaniciBirimYetkileriRepository.Update(kullaniciBirimYetkileri);
        }
    }
}
