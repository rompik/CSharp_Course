using Model;
using _14_Repository_ADO_EF_Dapper_AdoDAL;

using System.Data.Entity;
using Model.DAL;

namespace EntityDAO
{
    public class DataContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<City> Cities { get; set; }

        public DataContext()
            : base("Data Source=localhost;Initial Catalog=DASamples;Integrated Securety=True")
        { }
    }

    internal class EntityRepository<T> : IRepository<T> where T : class, IDomainObject, new() {

        private readonly DataContext _context;

        public EntityRepository(DataContext context) {
            _context = context;
        }

        public IEnumerable<T> GetAll() {
            return _context.Set<T>();
        }

        public void Add(T obj) {
            _context.Set<T>().Add(obj);
        }

        public void Delete(T obj) {
            _context.Set<T>().Remove(obj);
        }
    }
    public class UnitOfWork : IUnitOfWork
    {
        private DataContext _context = new DataContext();
        private EntityRepository<Person> _persons;
        private EntityRepository<City> _cities;

        public IRepository<Person> Persons
        {
            get { return _persons ?? (_persons = new EntityRepository<Person>(_context));  }
        
        }

        public IRepository<City> Cities
        {
            get { return _cities ?? (_cities = new EntityRepository<City>(_context));  }
        }

        public bool SaveChanges() {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception) {
                return false;
            }
        }

        public void Discard() {
            _context.Dispose();
            _context = new DataContext();
        }

    }
}
