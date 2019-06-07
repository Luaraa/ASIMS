using ASIMS.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//订单管理
namespace ASIMS.Models.Methods
{
    public class OrderManagement
    {
        /// <summary>
        /// 查询所有订单
        /// </summary>
        /// <returns>订单列表</returns>
        public List<Market> GetAllMarket()
        {
            #region

            #endregion
            return null;
        }
        /// <summary>
        /// 查询用户或员工经手的订单
        /// </summary>
        /// <param name="id">用户或员工id</param>
        /// <returns>订单列表</returns>
        public List<Market> GetSomeoneMarket(string id)
        {
            #region

            #endregion
            return null;
        }
        /// <summary>
        /// 获取用户购买或员工经手的订单号为no的详细信息
        /// </summary>
        /// <param name="id">用户或员工id</param>
        /// <param name="no">订单号</param>
        /// <returns></returns>
        public Market GetOneMarket(string id,int no)
        {
            #region

            #endregion
            return null;
        }
        /// <summary>
        /// 审核并通过订单，即订单状态置1
        /// </summary>
        /// <param name="no">订单号</param>
        /// <returns>是否成功</returns>
        public bool CheckMarket(int no)
        {
            #region

            #endregion
            return false;
        }

    }
}
