<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminRestaurant.aspx.cs" Inherits="Food_ordering.AdminRestaurant" EnableEventValidation = "false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url('image/admin.jpg')">
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Back" runat="server" OnClick="Back_Click" Text="Back" />
    
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Font-Size="XX-Large" ForeColor="#993300" Text="Restaurants"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" OnRowDataBound = "OnRowDataBound"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" Width="537px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" style="margin-left: 550px">
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
        <br />
        <br />
        <asp:Label ID="RIDlbl" runat="server" Text="Restaurant ID: "></asp:Label>
&nbsp;
        <asp:TextBox ID="RIDtxt" runat="server" Height="18px" style="margin-left: 25px" Width="337px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="resNamelbl" runat="server" Text="Restaurant Name: "></asp:Label>
&nbsp;<asp:TextBox ID="resNametxt" runat="server" style="margin-left: 7px" Width="338px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="resLoclbl" runat="server" Text="Location: "></asp:Label>
&nbsp;<asp:TextBox ID="resLoctxt" runat="server" style="margin-left: 57px" Width="344px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="resTyplbl" runat="server" Text="Type: "></asp:Label>
&nbsp;<asp:TextBox ID="resTypTxt" runat="server" style="margin-left: 76px" Width="346px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="resStatlbl" runat="server" Text="Status: "></asp:Label>
&nbsp;<asp:TextBox ID="resStattxt" runat="server" style="margin-left: 69px" Width="348px"></asp:TextBox>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="updatebtn" runat="server" OnClick="updatebtn_Click" Text="Update" Width="100px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="insertbtn" runat="server" OnClick="insertbtn_Click" Text="Insert" Width="106px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="deletebtn" runat="server" OnClick="deletebtn_Click" Text="Delete" Width="102px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="additembtn" runat="server" OnClick="additembtn_Click" Text="Add Item To Menu" Width="160px" />
        <br />
    
    </div>
    </form>
</body>
</html>
