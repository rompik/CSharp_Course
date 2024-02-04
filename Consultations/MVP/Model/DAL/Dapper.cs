using Microsoft.Data.Sqlite;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Model.DAL
{
    public class DapperRepositiry<T> : IRepository<T>
        where T : class, IDomainObject, new()
    {
        SqliteConnection connection = new SqliteConnection("Data Source=TestDB.db");
        public void Add(T entity)
        {
            if (entity is Employee)
            {
                var sqlQuery = "INSERT INTO People (Name, Age) VALUES (@Name, @Age);";

                connection.Query<int>(sqlQuery, entity);
            }
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return connection.Query<T>("SELECT * FROM Employees").ToList();
        }

        public void Save()
        {

        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
