<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="requests.aspx.cs" Inherits="web_app.RequestsForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Requests</title>
</head>
<body>
    <form id="requestsForm" runat="server">
        <div>
            <asp:Label runat="server" Text="Course Requests"></asp:Label>
        </div>
        <div>
            <asp:Label runat="server" Text="Credit Hour Requests"></asp:Label>
        </div>
        <div>
            <asp:Button id="back" runat="server" Text="Back" OnClick="Back" />
        </div>
    </form>
</body>
</html>
