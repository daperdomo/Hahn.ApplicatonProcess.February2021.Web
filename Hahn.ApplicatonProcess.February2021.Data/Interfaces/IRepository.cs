using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Data.Interfaces
{
    public interface IRepository<T> where T : class, IBaseEntity
    {
        DbSet<T> Table { get; }
        IEnumerable<T> Get(Expression<Func<T, bool>> query);
        IEnumerable<T> ListAll();
        T First(Expression<Func<T, bool>> query);
        bool Exists(Expression<Func<T, bool>> query);
        T GetById(int Id);
        int Count();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void SaveChanges();
    }
}
