<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="phone_numbers.aspx.cs" Inherits="web_app.PhoneNumbersForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Phone Numbers</title>
</head>
<body>
    <form id="phoneNumbersForm" runat="server">
        <div>
            <asp:Label runat="server" Text="Phone Numbers"></asp:Label>
            <asp:Button id="add" runat="server" Text="Add" OnClick="Add" />
        </div>
        <div>
            <asp:Button id="back" runat="server" Text="Back" OnClick="Back" />
        </div>
    </form>
</body>
</html>
