<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="web_app.RegisterForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
</head>
<body>
    <form id="registerForm" runat="server">
        <div>
            <asp:Label runat="server" Text="Register"></asp:Label>
        </div>
        <div>&nbsp;First Name</div>
        <div>
            <asp:TextBox id="firstName" runat="server"></asp:TextBox>&nbsp;
        </div>
        <div>&nbsp;Last Name</div>
        <div>
            <asp:TextBox id="lastName" runat="server"></asp:TextBox>&nbsp;
        </div>
        <div>&nbsp;Password</div>
        <div>
            <asp:TextBox id="password" runat="server"></asp:TextBox>&nbsp;
        </div>
        <div>&nbsp;Faculty</div>
        <div>
            <asp:TextBox id="faculty" runat="server"></asp:TextBox>&nbsp;
        </div>
        <div>&nbsp;Email</div>
        <div>
            <asp:TextBox id="email" runat="server"></asp:TextBox>&nbsp;
        </div>
        <div>&nbsp;Major</div>
        <div>
            <asp:TextBox id="major" runat="server"></asp:TextBox>&nbsp;
        </div>
        <div>&nbsp;Semester</div>
        <div>
            <asp:TextBox id="semester" runat="server"></asp:TextBox>&nbsp;
        </div>
        <div>
            <asp:Button id="register" runat="server" Text="Register" OnClick="Register" />
            <asp:Button id="back" runat="server" Text="Back" OnClick="Back" />
        </div>
    </form>
</body>
</html>
