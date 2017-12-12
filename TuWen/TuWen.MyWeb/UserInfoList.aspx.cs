using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TuWen.BLL;
using TuWen.Model;
using System.Text;

namespace TuWen.MyWeb
{
    public partial class UserInfoList : System.Web.UI.Page
    {
        public StringBuilder sb { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            sb = new StringBuilder();
            UserInfoBll userInfoBll = new UserInfoBll();
            List<UserInfo> list = userInfoBll.GetEntity();
            foreach (UserInfo userInfo in list)
            {
                //id,userName, passWord, tel, qq, province, city, school, grade, regtime
                sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td>{8}</td><td>{9}</td><td>{10}</td><td><a>修改</a></td><td><a>删除</a></td></tr>", userInfo.ID, userInfo.UserName, userInfo.PassWord, userInfo.Tel, userInfo.QQ, userInfo.Province, userInfo.District, userInfo.City, userInfo.School, userInfo.Grade, userInfo.Regtime);
            }
        }
    }
}