<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main_menu.aspx.cs" Inherits="web_app.MainMenuForm" %>

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
            <asp:Button ID="phoneNumbers" runat="server" Text="View Phone Numbers" OnClick="ViewPhoneNumbers" />
            <asp:Button ID="courses" runat="server" Text="View Courses" OnClick="ViewCourses" />
            <asp:Button ID="requests" runat="server" Text="View Requests" OnClick="ViewRequests" />
            <asp:Button ID="logOut" runat="server" Text="Log Out" OnClick="LogOut" />
        </div>
    </form>
</body>
</html>
