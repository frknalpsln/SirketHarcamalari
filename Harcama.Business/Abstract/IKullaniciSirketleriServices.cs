﻿using Harcama.Entities.Concrete;
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

        Task<bool> AddAsync(KullaniciSirketleri kullaniciSirketleri);
        bool Remove(KullaniciSirketleri kullaniciSirketleri);
        Task<bool> RemoveAsync(string id);
        bool Update(KullaniciSirketleri kullaniciSirketleri);
    }
}
