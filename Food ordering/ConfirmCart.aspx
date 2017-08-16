<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmCart.aspx.cs" Inherits="Food_ordering.ConfirmCart" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript">
       
        function checkButtonStatus(){
               if (document.getElementById("TrxInput").value.length >=1) {
                   document.getElementById("ConfirmPayment").disabled = false;
               }
               else{
                   document.getElementById("ConfirmPayment").disabled = true;
               }
               
        }

    </script>
</head>
<body style="background-image:url('image/admin.jpg')">
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Button ID="back" runat="server" OnClick="back_Click" Text="Back" />
        <br />
        <asp:Label ID="item" runat="server" Text="Item:   "></asp:Label>
        <asp:Label ID="itemvalue" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="quantity" runat="server" Text="Quantity:  "></asp:Label>
        <asp:Label ID="quantityvalue" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
    
    </div>
        <asp:Label ID="TotalBill" runat="server" Text="Total Bill :  "></asp:Label>
        <asp:Label ID="getbill" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Enter Your Bkash  TrxID:  "></asp:Label>
        <p>
            <asp:TextBox ID="TrxInput" runat="server" onkeyup="checkButtonStatus();"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ConfirmPayment" runat="server" OnClick="ConfirmPayment_Click" Text="Confirm" Enabled ="false" />
        </p>
    </form>
</body>
</html>
