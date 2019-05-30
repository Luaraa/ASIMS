//管理员及销售人员信息管理模块

using ASIMS.Models;

namespace AdminInfor
{
    class AdminInforManagement
    {
        /// <summary>
        /// 处理管理员以及销售员工的登录请求
        /// </summary>
        /// <param name="id">管理员或销售员工用户账号</param>
        /// <param name="password">管理员或销售员工用户密码</param>
        /// <returns>可以登录返回true</returns>
        public bool Login(string id,string password)
        {
            return false;
        }
        /// <summary>
        /// 修改管理员或销售员工用户密码
        /// </summary>
        /// <param name="id">员工账号</param>
        /// <param name="password">员工密码</param>
        /// <returns>修改成功返回true</returns>
        public bool NewPassword(string id,string password)
        {
            return false;
        }
        /// <summary>
        /// 修改员工个人信息
        /// </summary>
        /// <param name="id">用户id</param>
        /// <param name="staff">员工（员工中的信息已经更新，需要加入数据库）</param>
        /// <returns>修改成功返回true</returns>
        public bool ModifyInformation(string id,Staffinfo staff)
        {
            return false;
        }

    }

}



