using Demo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Repository
{
    public class UserRepository
    {
        //Initialize the db context
        private DemoContext _Context;
        public UserRepository()
        {
            //Creating the db context object
            _Context = new DemoContext();
        }

        //Validate User by user name and passord
        public bool ValidateUser(string userName, string Password)
        {

            var result = _Context.UserMasters.SingleOrDefault(x => x.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase) && x.Password == Password);
            
            return result != null ? true : false;
        }
    }
}
