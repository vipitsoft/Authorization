using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class UserDAL
    {
        AuthorizationDBContext _authorizationDBContext;
        public UserDAL(AuthorizationDBContext authorizationDBContext)
        {
            _authorizationDBContext = authorizationDBContext;
        }

        public User Login(string userName, string password)
        {
            User user =  _authorizationDBContext.Users.Include(t=>t.Role).Where(w => w.UserName == userName && w.Password == password).FirstOrDefault();
            return user;
        }
    }
}
