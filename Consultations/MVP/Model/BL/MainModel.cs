﻿using Model.DAL;
using Model.Model;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BL
{
    public class MainModel : IMainModel
    {
        public IRepository<Employee> _repository { get; }

        public MainModel(IRepository<Employee> repository )
        {
            _repository = repository;
        }

        public event EventHandler<EmployeeEventArgs> EventAddEmployee; //= delegate { };
        public event EventHandler<EmployeeEventArgs> EventDelEmployee; //= delegate { };

        public void AddEmployee(Employee employee)
        {
            _repository.Add(employee);
            EventAddEmployee?.Invoke(this, new EmployeeEventArgs(employee));
        }

        public void DeleteEmployee(Employee employee)
        {
            _repository.Delete(employee);
            EventDelEmployee?.Invoke(this, new EmployeeEventArgs(employee));
        }

        public IList<Employee> GetEmployees()
        {
            return _repository.GetAll().ToList();
        }
    }
}
