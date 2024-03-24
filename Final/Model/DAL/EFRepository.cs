﻿using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public class EFRepository<T> : IRepository<T> where T: class, IDomainObject, new()
    {
        private Context _context = new Context();

        public IEnumerable<T> GetAll() { }

        public void Add(T entity) { }

        public void Update(T entity) { }

        public void Delete(T entity) { }

        public void Save() { }  
    }
}
