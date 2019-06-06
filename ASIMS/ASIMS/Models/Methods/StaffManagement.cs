using ASIMS.Models.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// 员工管理
/// </summary>
namespace ASIMS.Models.Methods
{
    public class StaffManagement
    {
        /// <summary>
        /// 添加员工
        /// </summary>
        /// <param name="staff">员工</param>
        /// <returns></returns>
        public bool AddStaff(Staff staff)
        {
            #region
            #endregion
            return false;
        }
        /// <summary>
        /// 删除员工
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        public bool DeleteStaff(string sid)
        {
            #region
            using (var dbcontext = new asimsContext())
            {
                var query = dbcontext.Staff
                    .FirstOrDefault(s => s.Sphone == sid && s.Stype != "管理员");
                if (query != null)
                {
                    dbcontext.Staff.Remove(query);
                    dbcontext.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            #endregion
        }
        /// <summary>
        //根据id获取员工详情
        /// </summary>
        /// <param name="id">员工id</param>
        /// <returns>员工</returns>
        public Staff SearchStaffThoughId(string id)
        {
            #region
            #endregion
            return null;
        }
        /// <summary>
        /// 通过姓名查找用户（模糊查找）
        /// </summary>
        /// <param name="name">姓名</param>
        /// <returns></returns>
        public List<Staff> SearchStaffThoughName(string name)
        {
            var dbcontext = new asimsContext();
            var query = dbcontext.Staff
                .Where(s => s.Sname.Contains(name)).ToList();
            return query;
        }
        /// <summary>
        /// 获取所有员工
        /// </summary>
        /// <returns></returns>
        public List<Staff> GetAllStaff()
        {
            #region
            #endregion
            return null;
        }
        /// <summary>
        //更改员工权限到最高级
        /// </summary>
        /// <param name="id">员工id</param>
        /// <returns></returns>
        public bool ImproveLevel(string id)
        {
            return false;
        }
    }
}
