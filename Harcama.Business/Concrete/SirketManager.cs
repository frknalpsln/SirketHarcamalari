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
    public class SirketManager : ISirketServices
    {
        private readonly ISirketRepository _sirketRepository;

        public SirketManager(ISirketRepository sirketRepository)
        {
            _sirketRepository = sirketRepository;
        }

        async Task<bool> ISirketServices.AddAsync(Sirket sirket)
        {
            return await _sirketRepository.AddAsync(sirket);
        }

        IQueryable<Sirket> ISirketServices.GetAll()
        {
            return _sirketRepository.GetAll();
        }

        bool ISirketServices.Remove(Sirket sirket)
        {
            return _sirketRepository.Remove(sirket);
        }

        async Task<bool> ISirketServices.RemoveAsync(string id)
        {
            return await _sirketRepository.RemoveAsync(id);
        }

        bool ISirketServices.Update(Sirket sirket)
        {
            return _sirketRepository.Update(sirket);
        }
    }
}
