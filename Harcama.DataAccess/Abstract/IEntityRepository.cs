using Harcama.Entities.Common;
using Harcama.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T :  BaseEntity
    {
        DbSet<T> Table { get; }

        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetSingleAsync(string id, bool tracking = true);
        Task<bool> AddAsync(T model);

        Task<bool> AddRangeAsync(List<T> models);
        bool Remove(T model);
        Task<bool> RemoveAsync(string id);
        bool Update(T model);
        Task<int> SaveAsync();
    }
}
