<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmOrder.aspx.cs" Inherits="Food_ordering.ConfirmOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Confirm order</title>
    <script language="javascript" type="text/javascript">
        function checkButtonStatus() {
            if (document.getElementById("TrxInput").value.length == 10) {
                document.getElementById("ConfirmPayment").disabled = false;

            }
            else {
                document.getElementById("ConfirmPayment").disabled = true;
            }
        }

    </script>
    
</head>
<body style="background-image:url('image/admin.jpg')">
    
    <form id="form1" runat="server">
    
    
        
               
        
        

         
        <div class="main4">
        <br />
        <asp:Label ID="item" runat="server" Text="Item:   "  ></asp:Label>
        <asp:Label ID="itemvalue" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="quantity" runat="server" Text="Quantity:  "></asp:Label>
        <asp:Label ID="quantityvalue" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
    
    
        <asp:Label ID="TotalBill" runat="server" Text="                            Total Bill :  "></asp:Label>
        <asp:Label ID="getbill" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Enter Your Bkash  TrxID:  "></asp:Label>
        <p>
            <asp:TextBox ID="TrxInput" runat="server" onkeyup="checkButtonStatus();"></asp:TextBox>
            <asp:Button ID="ConfirmPayment" runat="server" OnClick="ConfirmPayment_Click" Text="Confirm" Enabled="false" style="margin-left: 17px; margin-bottom: 6px" Width="101px" />
        </p>
        <p>
            <asp:ImageButton ID="ImageButton1" runat="server" Height="34px" ImageUrl="~/images/back.jpg" OnClick="ImageButton1_Click" style="margin-left: 52px; margin-top: 0px" Width="93px" />
            </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
            </div>
    </form>
        
</body>
</html>

