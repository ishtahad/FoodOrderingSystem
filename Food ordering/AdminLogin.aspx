<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Food_ordering.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url('image/admin.jpg')">
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="usernamelbl" runat="server" Text="Admin ID"></asp:Label>
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:TextBox ID="usernametxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="passwordlbl" runat="server" Text="Password"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="passwordtxt" TextMode="Password" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="loginbtn" runat="server" style="margin-left: 0px" Text="Log In" Width="99px" OnClick="loginbtn_Click" />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
