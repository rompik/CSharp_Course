using Model.Model;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public class Context : DbContext
    {
        public DbSet<Employee> Employees { get; set; } = null!;

        public Context()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=TestDB.db");
        }
    }


    public class EFRepository<T> : IRepository<T> where T : class, IDomainObject, new()
    {

        protected Context _context;
        protected DbSet<T> _dbSet;

        public EFRepository(Context context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            Save();
        }

        public void Delete(T entity)
        {

            if (entity != null)
            {
                _dbSet.Remove(entity);
                Save();
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            Save();
        }
    }

}
