<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="web_app.LoginForm" %>

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
            <asp:TextBox id="userId" runat="server"></asp:TextBox>&nbsp;
        </div>
        <div>&nbsp;Password</div>
        <div>
            <asp:TextBox id="password" runat="server"></asp:TextBox>&nbsp;
        </div>
        <div>
            <asp:Button id="login" runat="server" Text="Log In" OnClick="Login" />
            <asp:Button id="register" runat="server" Text="Register" OnClick="Register" />
        </div>
    </form>
</body>
</html>
