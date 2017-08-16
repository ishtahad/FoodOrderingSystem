<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="Food_ordering.Order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>

    <body style="background-image:url('image/admin.jpg')">

    <form id="form1" runat="server">
        
    <div class="main1">
    
    
        <asp:Label ID="OrderFrom" runat="server" Text="Order From:  "></asp:Label>
        <asp:Label ID="passres" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="OrderItem" runat="server" Text="Order Item:  "></asp:Label>
        <asp:Label ID="passitem" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Price" runat="server" Text="Price Per Item:  "></asp:Label>
        <asp:Label ID="passprice" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Quantity" runat="server" Text="Select Quantity:   "></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="QuantityList" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" Height="44px" ImageUrl="~/images/next.jpg" OnClick="ImageButton1_Click" Width="88px" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:ImageButton ID="ImageButton2" runat="server" Height="43px" ImageUrl="~/images/back.jpg" OnClick="ImageButton2_Click" Width="82px" />
        <br />
        <p>
            &nbsp;</p>
        </div>
    </form>
</body>
</html>

