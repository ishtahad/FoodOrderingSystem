
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Food_ordering.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <link href="Bootstrap/bootstrap.min.css" rel="stylesheet" />
    
</head>
<body style="background-image:url('image/loginpic4.jpg')">

    <form id="form1" runat="server">
        <div class="panel-img">
              <img src="image/glass3.png" style="margin-left: 295px; margin-top: 88px; margin-bottom: 3px" />
       </div>
       <div>
           
          <div style="position:absolute; z-index:1; top: 4px; left: 6px;" id="layer1">
             <div class="modal-body" style="margin:30px 0px 0px 400px; top: 54px; left: -1px;">
                 <div class="row">
                       <div class="col-xs-12">
                            <div class="form-group">
                                     <label for="username" class="control-label">Username</label>
                                     <asp:TextBox ID="usertxt" runat="server" class="form-control" title="Enter your user id" placeholder="ishtahad"></asp:TextBox>
                                       <span class="help-block"></span>
                          </div>

                           <div class="form-group">
                                   <label for="firstlbl" class="control-label">First NAME</label>
                                   <asp:TextBox ID="firsttxt" runat="server" class="form-control" title="Enter your First Name" placeholder="ishtahad/sakif/tulon"></asp:TextBox>
                               <span class="help-block"></span>
                           </div>


                           <div class="form-group">
                                   <label for="lastlbl" class="control-label">last NAME</label>
                                   <asp:TextBox ID="lasttxt" runat="server" class="form-control" title="Enter your last Name" placeholder="ishtahad/sakif/tulon"></asp:TextBox>
                               <span class="help-block"></span>
                           </div>

                            <div class="form-group">
                                   <label for="emaillbl" class="control-label">EMAIL</label>
                                   <asp:TextBox ID="emailtxt" runat="server" class="form-control" title="Enter your email" placeholder="som@gmail.com"></asp:TextBox>
                               <span class="help-block"></span>
                           </div>

                           <div class="form-group">
                              
                               <asp:Label ID="Label1" runat="server" class="control-label" Text="Password"></asp:Label>
                              
                              <asp:TextBox ID="passtxt" runat="server" class="form-control"></asp:TextBox>
                                <span class="help-block" />


                           </div>

                             <asp:Button ID="reg" runat="server" class="btn btn-success btn-block" Text="sign up" OnClick="reg_Click" />
    
                             </div>
                     </div>
                 </div>
              </div>
           </div>

       
        
        
        
        
        
        
        
        
        
        
        
             
    
    
    </form>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>


