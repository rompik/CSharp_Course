using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public class FakeRepository<T> : IRepository<T>
        where T : IDomainObject, new()
    {
        private List<T> _data = new List<T>() { };

        public void Add(T entity)
        {
            _data.Add(entity);
        }

        public void Delete(T entity)
        {
            _data.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _data;
        }

        public void Update(T entity)
        {
            foreach (var item in _data)
            {
                if (item.Id == entity.Id)
                {
                    _data.Remove(item);
                    break;
                }
            }
            _data.Add(entity);
            //_data.RemoveAt(entity.Id);
        }
        public void Save()
        {
            throw new NotImplementedException();
        }


    }
}
