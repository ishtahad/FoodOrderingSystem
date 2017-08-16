<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminMenu.aspx.cs" Inherits="Food_ordering.AdminMenu" EnableEventValidation = "false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .m {
            margin-left: 663px;
        }
    </style>
</head>
<body style="background-image:url('image/admin.jpg'); height: 766px;">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label2" runat="server" Font-Size="XX-Large" ForeColor="#993300" Text="Restaurants"></asp:Label>
    
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Back" runat="server" Height="29px" OnClick="Back_Click" style="margin-left: 487px; margin-top: 0px" Text="Back" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" OnRowDataBound = "OnRowDataBound"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" Width="537px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" style="margin-left: 481px">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <div class="m">
        <br />
        <br />
        <asp:Label ID="RIDlbl" runat="server" Text="Item ID: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="RIDtxt" runat="server" Height="18px" style="margin-left: 13px" Width="337px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="resNamelbl" runat="server" Text="Item Name: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="resNametxt" runat="server" style="margin-left: 7px" Width="338px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="resLoclbl" runat="server" Text="Description:  "></asp:Label>
&nbsp; <asp:TextBox ID="resLoctxt" runat="server" style="margin-left: 15px" Width="344px" Height="24px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="resTyplbl" runat="server" Text="Status"></asp:Label>
&nbsp;<asp:TextBox ID="resTypTxt" runat="server" style="margin-left: 18px" Width="346px" Height="29px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="resStatlbl" runat="server" Text="Price: "></asp:Label>
&nbsp;<asp:TextBox ID="resStattxt" runat="server" style="margin-left: 16px" Width="348px" Height="25px"></asp:TextBox>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="updatebtn" runat="server" OnClick="updatebtn_Click" Text="Update" Width="103px" style="margin-left: 35px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="insertbtn" runat="server" OnClick="insertbtn_Click" Text="Insert" Width="103px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="deletebtn" runat="server" OnClick="deletebtn_Click" Text="Delete" Width="108px" />
        <br />
            </div>
    
    </div>
    </form>
</body>
</html>