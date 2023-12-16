<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main_menu.aspx.cs" Inherits="web_app.MainMenuForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Menu</title>
</head>
<body>
    <form id="mainMenuForm" runat="server">
        <div>
            <asp:Label runat="server" Text="Main Menu"></asp:Label>
        </div>
        <div>
            <asp:Button id="phoneNumbers" runat="server" Text="View Phone Numbers" OnClick="ViewPhoneNumbers" />
            <asp:Button id="courses" runat="server" Text="View Courses" OnClick="ViewCourses" />
            <asp:Button id="requests" runat="server" Text="View Requests" OnClick="ViewRequests" />
            <asp:Button id="logOut" runat="server" Text="Log Out" OnClick="LogOut" />
        </div>
    </form>
</body>
</html>
