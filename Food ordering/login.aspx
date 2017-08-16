<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Food_ordering.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LOGIN</title>
    <link href="Bootstrap/bootstrap.min.css" rel="stylesheet" />
   
</head>
<body style="background-image:url('image/loginpic4.jpg')" >
    <form id="form1" runat="server">
    <div class="panel-img">
        <img src="image/glass3.png" style="margin-left: 295px; margin-top: 88px; margin-bottom: 3px" />
    </div>
   
    <div>
        <div style="position:absolute; z-index:1; top: 4px; left: 6px;" id="layer1">
            <div class="modal-body" style="margin:30px 0px 0px 400px; top: -37px; left: 4px; height: 777px; width: 546px;">
                <div class="row">
                                <span class="help-block" />


                    <p class="lead">Register Now For <span class="text-success">FREE</span></p>
                       </span>
                       <div class="col-xs-12">
                           <div class="form-group">
                               <label for="username" class="control-label">Username</label>
                               
                               <asp:TextBox ID="usernametxt" runat="server" class="form-control" title="Enter your user id" placeholder="name"></asp:TextBox>
                               <span class="help-block"></span>
                           </div>

                           <div class="form-group">
                              
                               <asp:Label ID="passwordlbl" runat="server" class="control-label" Text="Password"></asp:Label>
                              
                              <asp:TextBox ID="passwordtxt" TextMode="Password" runat="server" class="form-control"></asp:TextBox>
                                <span class="help-block" />


                           </div>

                           
                           <asp:Button ID="loginbtn" runat="server" class="btn btn-success btn-block" Text="LOG IN" OnClick="loginbtn_Click" />
                       </div>
                     <div class="col-xs-18">
                         <p class="lead">
                                <span class="help-block" />

                          <asp:Button ID="regi" runat="server" Class="btn btn-success btn-block" Text="registration" OnClick="regbtn_Click" />
                          <asp:Button ID="admin" runat="server" Class="btn btn-success btn-block" Text="admin" OnClick="admin_Click" />
                     <p>
                          &nbsp;</p>    
                </div>
                </div>
               
            </div>
        </div>
    </div>


    </form>

    <script src="js/bootstrap.min.js"></script>
</body>
</html>
