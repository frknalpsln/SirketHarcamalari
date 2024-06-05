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
    public class ProjeTanimlariManager : IProjeTanimlariServices
    {
        private readonly IProjeTanimlariRepository _projeTanimlariRepository;

        public ProjeTanimlariManager(IProjeTanimlariRepository projeTanimlariRepository)
        {
            _projeTanimlariRepository = projeTanimlariRepository;
        }

        public async Task<bool> AddAsync(ProjeTanimlari projeTanimlari)
        {
        return  await  _projeTanimlariRepository.AddAsync(projeTanimlari);
        }

        public IQueryable<ProjeTanimlari> GetAll()
        {
           return _projeTanimlariRepository.GetAll(); 
        }

        public bool Remove(ProjeTanimlari projeTanimlari)
        {
           return _projeTanimlariRepository.Remove(projeTanimlari);
        }

        public async Task<bool> RemoveAsync(string id)
        {
        return  await _projeTanimlariRepository.RemoveAsync(id);
        }

        public bool Update(ProjeTanimlari projeTanimlari)
        {
         return  _projeTanimlariRepository.Update(projeTanimlari);
        }
    }
}
