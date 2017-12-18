<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="TuWen.MyWeb.Add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, minimum-scale=0.5, maximum-scale=2.0, user-scalable=yes" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <table border="1" cellpadding="0" cellspacing="0">
        <tr>
            <td>
                用户名
            </td>
            <td>
                <input type="text" name="userName" value="" />
            </td>
        </tr>
        <tr>
            <td>
                密码
            </td>
            <td>
                <input type="text" name="passWord" value="" />
            </td>
        </tr>
        <tr>
            <td>
                手机
            </td>
            <td>
                <input type="text" name="tel" value="" />
            </td>
        </tr>
        <tr>
            <td>
                QQ
            </td>
            <td>
                <input type="text" name="qq" value="" />
            </td>
        </tr>
        <tr>
            <td>
                省
            </td>
            <td>
                <select id="cmbProvince" name="cmbProvince">
                </select>
            </td>
        </tr>
        <tr>
            <td>
                市
            </td>
            <td>
                <select id="cmbCity" name="cmbCity">
                </select>
            </td>
        </tr>
        <tr>
            <td>
                区/县
            </td>
            <td>
                <select id="cmbArea" name="cmbArea">
                </select>
            </td>
        </tr>
        <tr>
            <td>
                学校
            </td>
            <td>
                <input type="text" name="school" value="" />
            </td>
        </tr>
        <tr>
            <td>
                年级
            </td>
            <td>
                <input type="text" name="grade" value="" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <input type="submit" name="" value="注册" />
            </td>
        </tr>
    </table>
    </form>
</body>
<script src="js/jsAddress.js" type="text/javascript"></script>
<script type="text/javascript">
    addressInit('cmbProvince', 'cmbCity', 'cmbArea');  
</script>
</html>
