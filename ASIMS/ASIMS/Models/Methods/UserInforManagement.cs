﻿using ASIMS.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//用户信息管理
namespace ASIMS.Models.Methods
{
    public class UserInforManagement
    {
        /// <summary>
        /// 处理用户的注册
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <param name="address">地址号</param>
        /// <returns></returns>
        public bool Register(User user,int address)
        {
            #region

            #endregion
            return false;
        }
        /// <summary>
        /// 处理用户的登录请求
        /// </summary>
        /// <param name="id">用户id</param>
        /// <param name="password">用户密码</param>
        /// <returns></returns>
        public bool Login(string id,string password)
        {
            #region

            #endregion
            return false;
        }
        /// <summary>
        /// 用户修改密码
        /// </summary>
        /// <param name="id"></param>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        public bool NewPassword(string id,string oldPassword,string newPassword)
        {
            #region

            #endregion
            return false;
        }
        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="id">用户id</param>
        /// <param name="user">用户对象</param>
        /// <param name="address">地址编号</param>
        /// <returns></returns>
        public bool ModifyInformation(string id,User user,int address)
        {
            #region
            using (var dbcontext = new asimsContext())
            {
                var users = dbcontext.User
                    .Single(use => use.Uphone == id);
                if (users != null)
                {
                    users = user;
                    user.Uaddress = address;
                    dbcontext.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
                #endregion
        }
    }
}
