using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UserPrincipal : ClaimsPrincipal
    {
        public UserPrincipal(UserIdentity identity)
        {
            Identity = identity;
        }

        public override IIdentity Identity
        {
            get;
        }

        private UserIdentity userIdentity
        {
            get
            {
                return Identity as UserIdentity;
            }
        }

        public override bool IsInRole(string role)
        {
            return false;
            //try
            //{
            //    if (!string.IsNullOrEmpty(role) && codeformIdentity.Roles != null)
            //    {
            //        foreach (var item in role.Split(','))
            //        {
            //            if (codeformIdentity.Roles.Contains(item))
            //            {
            //                return true;
            //            }
            //        }
            //    }
            //    return false;
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
        }
    }
}
