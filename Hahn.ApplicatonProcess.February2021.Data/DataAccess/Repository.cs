using Hahn.ApplicatonProcess.February2021.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Data.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class, IBaseEntity
    {
        protected readonly DbContext _context;
        public DbSet<T> Table { get; }

        public Repository(DbContext context)
        {
            _context = context;
            Table = context.Set<T>();
        }

        public T GetById(int Id)
        {
            return Table.FirstOrDefault(m => m.Id == Id);
        }

        public int Count()
        {
            return Table.Count();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> query)
        {
            return Table.Where(query).ToList();
        }

        public T First(Expression<Func<T, bool>> query)
        {
            return Table.FirstOrDefault(query);
        }

        public bool Exists(Expression<Func<T, bool>> query)
        {
            return Table.Any(query);
        }

        public IEnumerable<T> ListAll()
        {
            return Table.ToList();
        }

        public void Create(T entity)
        {
            Table.Add(entity);
        }

        public void Delete(T entity)
        {
            Table.Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
