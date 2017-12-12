<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfoList.aspx.cs" Inherits="TuWen.MyWeb.UserInfoList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <a href="Add.aspx">添加用户</a>
    <%--    <form id="form1" runat="server">--%>
    <table border="1" cellpadding="1" cellspacing="1">
        <tr>
            <th>
                ID
            </th>
            <th>
                用户名
            </th>
            <th>
                密码
            </th>
            <th>
                手机
            </th>
            <th>
                QQ
            </th>
            <th>
                省
            </th>
            <th>
                区
            </th>
            <th>
                市
            </th>
            <th>
                学校
            </th>
            <th>
                年级
            </th>
            <th>
                注册时间
            </th>
            <th>
                修改
            </th>
            <th>
                删除
            </th>
        </tr>
        <%=sb.ToString() %>
    </table>
    <%--    </form>--%>
</body>
</html>
