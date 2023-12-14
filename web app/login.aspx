<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="web_app.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="loginForm" runat="server">
        <div>
            <asp:Label runat="server" Text="Log In"></asp:Label>
        </div>
        <div>&nbsp;User ID</div>
        <div>
            <asp:TextBox ID="userID" runat="server"></asp:TextBox>&nbsp;
        </div>
        <div>&nbsp;Password</div>
        <div>
            <asp:TextBox ID="password" runat="server"></asp:TextBox>&nbsp;
        </div>
        <div>
            <asp:Button ID="login" runat="server" Text="Log In" OnClick="Login" />
            <asp:Button ID="register" runat="server" Text="Register" OnClick="Register" />
        </div>
    </form>
</body>
</html>
