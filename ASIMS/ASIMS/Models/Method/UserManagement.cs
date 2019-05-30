using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// 用户管理模块，实现的功能有，
/// 1.列出所有的用户
/// 2.查看某一用户的详细信息
/// </summary>
namespace ASIMS.Models.Method
{
    public class UserManagement
    {
        /// <summary>
        /// 查看所有用户
        /// </summary>
        /// <returns>所有用户</returns>
        public List<User> ListAllUser()
        {
            List<User> users = new List<User>();
            #region

            #endregion
            return users;
        }
        /// <summary>
        /// 查看账号为id用户的详细信息
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns>账号为id的用户</returns>
        public User GetUserDetail(string id)
        {
            User user = new User();
            #region


            #endregion
            return user;
        }
    }
}
