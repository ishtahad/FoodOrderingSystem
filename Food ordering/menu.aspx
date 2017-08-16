<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="Food_ordering.menu" EnableEventValidation = "false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> RESTAURENTS</title>
    <link href="Bootstrap/bootstrap.min.css" rel="stylesheet" />
</head>
<body style="background-image:url('image/admin.jpg')">
    <form id="form1" runat="server">
        

        <asp:ImageButton ID="ImageButton1" runat="server" Height="38px" ImageUrl="~/images/back.jpg" OnClick="ImageButton1_Click" />
        

        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Font-Size="XX-Large" ForeColor="#993300" Text="Restaurants"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        
        
       

        <asp:DropDownList ID="SearchList" runat="server">
            <asp:ListItem>Restaurant</asp:ListItem>
            <asp:ListItem>Location</asp:ListItem>
            <asp:ListItem>Type</asp:ListItem>
        </asp:DropDownList>
        
        
        <br />
        <br />


       

                </div>
            </div>
        
        
       

        <br />
        <asp:Button ID="searchbtn" runat="server" OnClick="searchbtn_Click" Text="Search" />
        <br />
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />

        <div>
        <asp:GridView ID="GridView1" runat="server" OnRowDataBound = "OnRowDataBound"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" Width="609px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Height="190px">
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
    
    </div>
    </form>
</body>
</html>


