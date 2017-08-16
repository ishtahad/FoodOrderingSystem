<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Food_ordering.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    .main4{border: 1px solid #78909c;
     background-color:#212121;
     color:#bcaaa4;
            height: 1073px;
        }
        </style>
</head>
    
    <div class="main4">
<body style="height: 697px">
    
    

    <form id="form1" runat="server">

    
       



     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Interval="3000" OnTick="Timer1_Tick"></asp:Timer>
        <asp:Image ID="Image1" Height="400px" Width="1360px" runat="server" />
            </ContentTemplate>
        </asp:UpdatePanel>

       
        
        


    
    
        <asp:ImageButton ID="ImageButton1" runat="server" Height="163px" ImageAlign="Middle" ImageUrl="~/images/menu.png" OnClick="ImageButton1_Click" style="margin-left: 266px; margin-top: 0px" Width="179px" />
        
        <asp:ImageButton ID="ImageButton2" runat="server" Height="148px" ImageUrl="~/images/logout.png" OnClick="ImageButton2_Click" style="margin-left: 306px; margin-top: 50px" Width="123px" />
        
        </form>
    </body>
        </div>


</html>
