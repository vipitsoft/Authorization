using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class User
    {
        public int ID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int RoleID { get; set; }

        public virtual Roles Role { get; set; }
        public string AuthenticationType { get; set; }
    }
}
