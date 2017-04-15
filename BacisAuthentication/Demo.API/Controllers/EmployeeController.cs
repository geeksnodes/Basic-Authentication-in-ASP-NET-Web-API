using Demo.API.Models;
using Demo.Data.Entity;
using Demo.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Demo.API.Controllers
{
    public class EmployeeController : ApiController
    {

        private EmployeeRepository emp = new EmployeeRepository();
        // GET api/Employee
        [BacisAthentication]
        public IEnumerable<Employee> Get()
        {
            return emp.GetAll();
        }

        // GET api/Employee/5
        [BacisAthentication]
        public Employee Get(int id)
        {
            return emp.GetByID(id);
        }
    }
}