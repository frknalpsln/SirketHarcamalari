using Harcama.Business.Abstract;
using Harcama.DataAccess.Abstract;
using Harcama.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.Business.Concrete
{
    public class KullaniciManager : IKullaniciServices
    {
        private readonly IKullaniciRepository _kullaniciRepository;

        public KullaniciManager(IKullaniciRepository kullaniciRepository)
        {
            _kullaniciRepository = kullaniciRepository;
        }

        public async Task<bool> AddAsync(Kullanici kullanici)
        {
       return   await  _kullaniciRepository.AddAsync(kullanici);
        }

        public IQueryable<Kullanici> GetAll()
        {
         return   _kullaniciRepository.GetAll();  
        }

        public bool Remove(Kullanici kullanici)
        {
         return _kullaniciRepository.Remove(kullanici);
        }

        public async Task<bool> RemoveAsync(string id)
        {
         return await _kullaniciRepository.RemoveAsync(id);
        }

        public bool Update(Kullanici kullanici)
        {
          return  _kullaniciRepository.Update(kullanici);
        }
    }
}
