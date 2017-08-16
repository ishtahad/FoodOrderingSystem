<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="Food_ordering.test" EnableEventValidation = "false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> RESTAURENTS</title>
    <link href="Bootstrap/bootstrap.min.css" rel="stylesheet" />
    
</head>
<body style="background-image:url('image/loginpic4.jpg')">>
    <form id="form1" runat="server">
    <div style="position:absolute; z-index:1; top: 487px; left: 6px;" id="layer1">
    
    
    
        
    
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
        <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
        </asp:Timer>
        <asp:Image ID="Image1" Height="458px" Width="1366px" runat="server" />
                </ContentTemplate>
            </asp:UpdatePanel>
        <br />
        <br />
    
        <asp:Label ID="Label2" runat="server" Font-Size="XX-Large" ForeColor="#993300" Text="Label"></asp:Label>
    
    </div>
          <asp:Button ID="back" runat="server" OnClick="back_Click" Text="Back" />
          <asp:GridView ID="GridView1" runat="server" OnRowDataBound = "OnRowDataBound"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" Width="537px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" style="margin-left: 262px; margin-top: 141px">
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
        <asp:ImageButton ID="ImageButton1" runat="server" Height="45px" ImageUrl="~/images/back.jpg" OnClick="ImageButton1_Click" style="margin-left: 530px; margin-top: 180px" Width="106px" />
    </form>
        </div>

</body>
</html>
