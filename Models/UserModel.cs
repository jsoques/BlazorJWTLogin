using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTLogin.Models
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string password { get; set; }
    }
}
