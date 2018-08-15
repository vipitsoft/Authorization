using System.Security.Principal;

namespace Models
{
    public class UserIdentity : IIdentity
    {
        public UserIdentity(string name, int userId, string roleName, string[] rights)
        {
            Name = name;
            UserId = userId;
            RoleName = roleName;
            Rights = rights;
        }

        public string AuthenticationType
        {
            get { return "AuthenticationScheme"; }
        }

        /// <summary>
        /// 是否已登录
        /// </summary>
        public bool IsAuthenticated
        {
            get { return !string.IsNullOrEmpty(Name); }
        }

        /// <summary>
        /// 登录账号
        /// </summary>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// 登录账号对应的用户ID
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 角色名
        /// </summary>
        public string RoleName { get; set; }


        public string[] Rights { get; set; }


    }
}