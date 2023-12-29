using Model.Model;

namespace Model.DAL
{
    public interface IRepository<T> where T : IDomainObject, new()
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save(T entity);


    }
}
