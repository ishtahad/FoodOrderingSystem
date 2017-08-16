<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Food_ordering.Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 792px;
        }
    </style>
</head>
<body style="background-image:url('menuimg/3.jpg')">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="Back" runat="server" OnClick="Back_Click" Text="Back" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True"

DataKeyNames="Cart_ID" OnPageIndexChanging="PaginateTheData" EnablePersistedSelection="True"

PageSize="15" PagerSettings-Mode="Numeric" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="660px" style="margin-left: 490px; margin-right: 40px">

<Columns>



 <asp:BoundField DataField="Cart_ID" HeaderText="Cart_ID" SortExpression="Cart_ID" InsertVisible="False" ReadOnly="True" />
                <asp:BoundField DataField="Ordered_by" HeaderText="Ordered_by" SortExpression="Ordered_by" />
                <asp:BoundField DataField="Ordered_from" HeaderText="Ordered_from" SortExpression="Ordered_from" />
                <asp:BoundField DataField="Ordered_item" HeaderText="Ordered_item" SortExpression="Ordered_item" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
             
    <asp:TemplateField HeaderText="Select">

<ItemTemplate>

<asp:CheckBox ID="chkSelect" runat="server" />
</ItemTemplate>
</asp:TemplateField>


</Columns>

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
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 625px; margin-right: 0px; margin-top: 0px;" Text="Order Selected Items" Width="199px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Remove Selected Items" style="margin-left: 624px" />
    &nbsp;</form>
</body>
</html>

        