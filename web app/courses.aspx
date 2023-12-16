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
        <div>
            <asp:TextBox ID="optionalCoursesSemesterCode" runat="server"></asp:TextBox>
            <asp:Button ID="refreshOptionalCourses" runat="server" Text="Refresh" OnClick="LoadOptionalCourses" />
        </div>
        <div id="optionalCoursesForm" runat="server"></div>
        <br>
        <div>
            <asp:Label runat="server" Text="Available Courses"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="availableCoursesSemesterCode" runat="server"></asp:TextBox>
            <asp:Button ID="refreshAvailableCourses" runat="server" Text="Refresh" OnClick="LoadAvailableCourses" />
        </div>
        <div id="availableCoursesForm" runat="server"></div>
        <br>
        <div>
            <asp:Label runat="server" Text="Required Courses"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="requiredCoursesSemesterCode" runat="server"></asp:TextBox>
            <asp:Button ID="refreshRequiredCourses" runat="server" Text="Refresh" OnClick="LoadRequiredCourses" />
        </div>
        <div id="requiredCoursesForm" runat="server"></div>
        <br>
        <div>
            <asp:Label runat="server" Text="Missing Courses"></asp:Label>
            <asp:Button ID="refreshMissingCourses" runat="server" Text="Refresh" OnClick="LoadMissingCourses" />
        </div>
        <div id="missingCoursesForm" runat="server"></div>
        <br>
        <div>
            <asp:Button ID="back" runat="server" Text="Back" OnClick="Back" />
        </div>
    </form>
</body>
</html>
