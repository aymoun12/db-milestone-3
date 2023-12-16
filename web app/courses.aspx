<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="courses.aspx.cs" Inherits="web_app.CoursesForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Courses</title>
</head>
<body>
    <form id="coursesForm" runat="server">
        <div>
            <asp:Label runat="server" Text="Optional Courses"></asp:Label>
        </div>
        <div id="optionalCoursesForm" runat="server"></div>
        <div>
            <asp:Label runat="server" Text="Available Courses"></asp:Label>
        </div>
        <div id="availableCoursesForm" runat="server"></div>
        <div>
            <asp:Label runat="server" Text="Required Courses"></asp:Label>
        </div>
        <div id="requiredCoursesForm" runat="server"></div>
        <div>
            <asp:Label runat="server" Text="Missing Courses"></asp:Label>
        </div>
        <div id="missingCoursesForm" runat="server"></div>
        <div>
            <asp:Button id="back" runat="server" Text="Back" OnClick="Back" />
        </div>
    </form>
</body>
</html>
