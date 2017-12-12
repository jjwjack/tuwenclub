using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TuWen.BLL;
using TuWen.Model;

namespace TuWen.MyWeb
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                UserInfoBll userInfoBll = new UserInfoBll();
                UserInfo userInfo = new UserInfo();
                userInfo.UserName = Request["userName"];
                userInfo.PassWord = Request["passWord"];
                userInfo.Tel = Request["tel"];
                userInfo.QQ = Request["qq"];
                userInfo.Province = Request["province"];
                userInfo.District = Request["district"];
                userInfo.City = Request["city"];
                userInfo.School = Request["school"];
                userInfo.Grade = Request["grade"];

                userInfoBll.InsertEntity(userInfo);
                Context.Response.Redirect("UserInfoList.aspx");
            }
            else
            {
                Context.Response.Write("1234");
            }

        }
    }
}