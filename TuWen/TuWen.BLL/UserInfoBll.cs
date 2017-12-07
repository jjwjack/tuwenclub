using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuWen.DAL;
using TuWen.Model;

namespace TuWen.BLL
{
    public class UserInfoBll
    {
        UserInfoDal userInfoDal = new UserInfoDal();
        //查
        public List<UserInfo> GetEntity()
        {
            return userInfoDal.GetUserList();
        }
        //增
        private int InsertEntity(UserInfo userInfo)
        {
            return userInfoDal.Insert(userInfo);
        }
        //删
        public int DeleteEntity(int id)
        {
            return userInfoDal.Delete(id);
        }
        //改
        public int UpdateEntity(UserInfo userInfo)
        {
            return userInfoDal.Update(userInfo);
        }
        //详细页
        public UserInfo ShowDetails(int id)
        {
            return userInfoDal.ShowDetails(id);
        }
    }
}
