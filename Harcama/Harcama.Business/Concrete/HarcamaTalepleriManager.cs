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
    public class HarcamaTalepleriManager : IHarcamaTalepleriServices
    {
        private readonly IHarcamaTalepleriRepository _harcamaTalepleriRepository;

        public HarcamaTalepleriManager(IHarcamaTalepleriRepository harcamaTalepleriRepository)
        {
            _harcamaTalepleriRepository = harcamaTalepleriRepository;
        }

        public async Task<bool> AddAsync(HarcamaTalepleri harcamaTalepleri)
        {
            return await _harcamaTalepleriRepository.AddAsync(harcamaTalepleri);
        }

        public IQueryable<HarcamaTalepleri> GetAll()
        {
            return _harcamaTalepleriRepository.GetAll();
        }

        public bool Remove(HarcamaTalepleri harcamaTalepleri)
        {
            return _harcamaTalepleriRepository.Remove(harcamaTalepleri);
        }

        public async Task<bool> RemoveAsync(string id)
        {
            return await _harcamaTalepleriRepository.RemoveAsync(id);
        }

        public bool Update(HarcamaTalepleri harcamaTalepleri)
        {
            return _harcamaTalepleriRepository.Update(harcamaTalepleri);
        }
    }
}
