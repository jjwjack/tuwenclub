using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuWen.Model;
using System.Data;
using System.Data.SqlClient;

namespace TuWen.DAL
{
    public class UserInfoDal
    {
        //查
        public List<UserInfo> GetUserList()
        {
            List<UserInfo> list = new List<UserInfo>();
            string sql = "SELECT * FROM userInfo";
            DataTable dt = SqlHelper.GetTable(sql, CommandType.Text);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    UserInfo userInfo = new UserInfo();
                    DrToUser(dr, userInfo);
                    list.Add(userInfo);
                }
            }
            return list;
        }
        //关系转数据
        private void DrToUser(DataRow dr, UserInfo userInfo)
        {
            userInfo.City = dr["city"] != DBNull.Value ? dr["city"].ToString() : string.Empty;
            userInfo.District = dr["district"] != DBNull.Value ? dr["district"].ToString() : string.Empty;
            userInfo.Grade = dr["grade"] != DBNull.Value ? dr["grade"].ToString() : string.Empty;
            userInfo.ID = Convert.ToInt32(dr["id"]);
            userInfo.PassWord = dr["passWord"] != DBNull.Value ? dr["passWord"].ToString() : string.Empty;
            userInfo.Province = dr["province"] != DBNull.Value ? dr["province"].ToString() : string.Empty;
            userInfo.QQ = dr["qq"] != DBNull.Value ? dr["qq"].ToString() : string.Empty;
            userInfo.Regtime = Convert.ToDateTime(dr["regTime"]);
            userInfo.School = dr["school"] != DBNull.Value ? dr["school"].ToString() : string.Empty;
            userInfo.Tel = dr["tel"] != DBNull.Value ? dr["tel"].ToString() : string.Empty;
            userInfo.UserName = dr["userName"] != DBNull.Value ? dr["userName"].ToString() : string.Empty;


        }
        //增
        public int Insert(UserInfo userInfo)
        {
            string sql = "INSERT INTO userList(userName, passWord, tel, qq, province, city, school, grade, regtime) VALUES(@userName, @passWord, @tel, @qq, @province, @city, @school, @grade, @regtime)";
            SqlParameter[] ps = {
                                      new SqlParameter("@userName",SqlDbType.NVarChar,32),
                                      new SqlParameter("@passWord",SqlDbType.NVarChar,32),
                                      new SqlParameter("@tel",SqlDbType.NVarChar,32),
                                      new SqlParameter("@qq",SqlDbType.NVarChar,32),
                                      new SqlParameter("@province",SqlDbType.NVarChar,32),
                                      new SqlParameter("@city",SqlDbType.NVarChar,32),
                                      new SqlParameter("@school",SqlDbType.NVarChar,32),
                                      new SqlParameter("@grade",SqlDbType.NVarChar,32),
                                      new SqlParameter("@regtime",SqlDbType.NVarChar,32)
                                       };
            ps[0].Value = userInfo.UserName;
            ps[1].Value = userInfo.PassWord;
            ps[2].Value = userInfo.Tel;
            ps[3].Value = userInfo.QQ;
            ps[4].Value = userInfo.Province;
            ps[5].Value = userInfo.City;
            ps[6].Value = userInfo.School;
            ps[7].Value = userInfo.Grade;
            ps[8].Value = userInfo.Regtime;
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, ps);
        }
        //删
        public int Delete(int id)
        {
            string sql = "DELETE FROM userInfo WHERE id=@id";
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new SqlParameter("@id", id));
        }
        //改
        public int Update(UserInfo userInfo)
        {
            //userName, passWord, tel, qq, province, city, school, grade, regtime
            string sql = "UPDATE userInfo SET userName=@userName, passWord=@passWord, tel=@tel, qq=@qq, province=@province, city=@city, school=@school, grade=@grade WHERE id=@id";
            SqlParameter[] ps = {
                                      new SqlParameter("@userName",SqlDbType.NVarChar,32),
                                      new SqlParameter("@passWord",SqlDbType.NVarChar,32),
                                      new SqlParameter("@tel",SqlDbType.NVarChar,32),
                                      new SqlParameter("@qq",SqlDbType.NVarChar,32),
                                      new SqlParameter("@province",SqlDbType.NVarChar,32),
                                      new SqlParameter("@city",SqlDbType.NVarChar,32),
                                      new SqlParameter("@school",SqlDbType.NVarChar,32),
                                      new SqlParameter("@grade",SqlDbType.NVarChar,32)
                                       };
            ps[0].Value = userInfo.UserName;
            ps[1].Value = userInfo.PassWord;
            ps[2].Value = userInfo.Tel;
            ps[3].Value = userInfo.QQ;
            ps[4].Value = userInfo.Province;
            ps[5].Value = userInfo.City;
            ps[6].Value = userInfo.School;
            ps[7].Value = userInfo.Grade;
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, ps);
        }
        //详细页
        public UserInfo ShowDetails(int id)
        {
            string sql = "SELECT * FROM userInfo WHERE id=@id";
            DataTable dt = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@id", id));
            UserInfo userInfo = new UserInfo();
            if (dt.Rows.Count > 0)
            {
                DrToUser(dt.Rows[0], userInfo);
            }
            return userInfo;
        }

    }
}
