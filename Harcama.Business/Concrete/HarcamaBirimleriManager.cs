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
    public class HarcamaBirimleriManager : IHarcamaBirimleriServices
    {
        private readonly IHarcamaBirimleriRepository _harcamaBirimleriRepository;

        public HarcamaBirimleriManager(IHarcamaBirimleriRepository harcamaBirimleriRepository)
        {
            this._harcamaBirimleriRepository = harcamaBirimleriRepository;
        }

        public async Task<bool> AddAsync(HarcamaBirimleri harcamaBirimleri)
        {
            return await _harcamaBirimleriRepository.AddAsync(harcamaBirimleri);
        }

        public IQueryable<HarcamaBirimleri> GetAll()
        {
            return _harcamaBirimleriRepository.GetAll();
        }

        public Task<HarcamaBirimleri> GetById(string id)
        {
            return _harcamaBirimleriRepository.GetSingleAsync(id);

        }

        public bool Remove(HarcamaBirimleri harcamaBirimleri)
        {
            return _harcamaBirimleriRepository.Remove(harcamaBirimleri);
        }

        public async Task<bool> RemoveAsync(string id)
        {
            return await _harcamaBirimleriRepository.RemoveAsync(id);
        }

        public Task<int> SaveAsync()
        {
          return  _harcamaBirimleriRepository.SaveAsync();
        }

        public bool Update(HarcamaBirimleri harcamaBirimleri)
        {
            return _harcamaBirimleriRepository.Update(harcamaBirimleri);
        }
    }
}
