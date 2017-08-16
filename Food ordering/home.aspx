<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Food_ordering.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> HOME </title>
    <link href="Bootstrap/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" language="javascript">
function DisableBackButton() {
window.history.forward()
}
DisableBackButton();
window.onload = DisableBackButton;
window.onpageshow = function(evt) { if (evt.persisted) DisableBackButton() }
window.onunload = function() { void (0) }
</script>
</head>
<body style="background-image:url('image/food.jpg')">
    <form id="form1" runat="server">
        
                     
                    
                
       
        <div class="col-xs-12">
            
            <asp:Button ID="logout" runat="server" class="btn btn-success" Text="logout" OnClick="LOGOUT_Click" Height="70px" />   
            <asp:Button ID="menu" runat="server" class="btn btn-success" Text="MENU" OnClick="MENU_Click" Height="44px" Width="84px" />
            <asp:Button ID="contact" runat="server" class="btn btn-success" OnClick="contact_Click" Text="CONTACT" Height="46px" />
            <asp:Button ID="mycart" runat="server" Text="MY CART" class="btn btn-success" OnClick="MYCART_Click" Height="49px" Width="156px"  />
          <asp:Button ID="about" runat="server" class="btn btn-success" Text="ABOUT US" OnClick="ABOUT_Click" Height="48px" Width="141px" />
           <asp:Button ID="myorders" runat="server" class="btn btn-success" Text="MY ORDERS" OnClick="my_click" />
            </div>
                      
    </form>
</body>
</html>
