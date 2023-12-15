<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdvisorRegistration.aspx.cs" Inherits="AdvisingSystem.AdvisorRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Advisor Registration</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Advisor Registration</h2>
            <div>
                <label for="txtAdvisorName">Advisor Name:</label>
                <asp:TextBox ID="txtAdvisorName" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="txtPassword">Password:</label>
                <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="txtEmail">Email:</label>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="txtOffice">Office:</label>
                <asp:TextBox ID="txtOffice" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
            </div>
        </div>
    </form>
</body>
</html>