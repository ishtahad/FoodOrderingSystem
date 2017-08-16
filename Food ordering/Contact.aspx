<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Food_ordering.Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> CONTACT</title>
    <link href="Bootstrap/bootstrap.min.css" rel="stylesheet" />
</head>
<body style="background-image:url('image/loginpic4.jpg')";>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <div style="position:absolute; z-index:1; top: 48px; left: 6px;" id="layer1">
            <div class="modal-body" style="margin:30px 0px 0px 400px;">
                <div class="row">
                      <div class="col-xs-3">
                          <div class="form-group">

        <asp:Label ID="llblsubject" runat="server"  Font-Size="Large" ForeColor="#6666FF" Text="Subject:" class="control-label"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="subjecttxt" runat="server" Height="23px" style="margin-left: 4px" Width="541px" class="form-control"></asp:TextBox>
        <br />
        <br />
                           
        <asp:Label ID="lblquery" runat="server" Font-Size="Large" ForeColor="#6666FF" Text="Your Query"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="querytxt" runat="server" Height="97px" style="margin-left: 0px" Width="541px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="submitbtn" runat="server" OnClick="submitbtn_Click" style="margin-left: 181px" Text="Submit" Width="139px"  class="btn btn-success btn-block" />
                              
                          </div>
                    </div>
                      <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="back" />
                </div>
            </div>


    </form>
</body>
</html>

