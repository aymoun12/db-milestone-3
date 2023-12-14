<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="web_app.RegisterForm" %>

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
            <asp:TextBox ID="firstName" runat="server"></asp:TextBox>&nbsp;
        </div>
        <div>&nbsp;Last Name</div>
        <div>
            <asp:TextBox ID="lastName" runat="server"></asp:TextBox>&nbsp;
        </div>
        <div>&nbsp;Password</div>
        <div>
            <asp:TextBox ID="password" runat="server"></asp:TextBox>&nbsp;
        </div>
        <div>&nbsp;Faculty</div>
        <div>
            <asp:TextBox ID="faculty" runat="server"></asp:TextBox>&nbsp;
        </div>
        <div>&nbsp;Email</div>
        <div>
            <asp:TextBox ID="email" runat="server"></asp:TextBox>&nbsp;
        </div>
        <div>&nbsp;Major</div>
        <div>
            <asp:TextBox ID="major" runat="server"></asp:TextBox>&nbsp;
        </div>
        <div>&nbsp;Semester</div>
        <div>
            <asp:TextBox ID="semester" runat="server"></asp:TextBox>&nbsp;
        </div>
        <div>
            <asp:Button ID="register" runat="server" Text="Register" OnClick="Register" />
            <asp:Button ID="back" runat="server" Text="Back" OnClick="Back" />
        </div>
    </form>
</body>
</html>
