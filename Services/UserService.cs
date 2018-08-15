using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class UserService
    {
        UserDAL _userDAL;
        public UserService(UserDAL userDAL)
        {
            _userDAL = userDAL;
        }

        public User Login(string userName, string password)
        {
            return _userDAL.Login(userName, password);
        }
    }
}
