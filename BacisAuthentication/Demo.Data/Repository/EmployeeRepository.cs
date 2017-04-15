using Demo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Repository
{
    public class EmployeeRepository
    {
        //Initialize the db context
        private DemoContext _Context;
        public EmployeeRepository()
        {
            //Creating the db context object
            _Context = new DemoContext();
        }

        public List<Employee> GetAll()
        {
            return _Context.Employees.ToList();
        }
        public Employee GetByID(int ID)
        {
            return _Context.Employees.Find(ID);
        }
    }
}
