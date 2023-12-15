<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailInstructorCourses.aspx.cs" Inherits="AdvisingSystem.DetailInstructorCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Detail Instructor Courses</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>View Details of Instructors and Their Assigned Courses</h2>
            <div>
                <label for="txtCourseID">Course ID:</label>
                <asp:TextBox ID="txtCourseID" runat="server" required="true" type="number"></asp:TextBox>
            </div>
            <div>
                <label for="txtInstructorID">Instructor ID:</label>
                <asp:TextBox ID="txtInstructorID" runat="server" required="true" type="number"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnViewDetails" runat="server" Text="View Details" OnClick="btnViewDetails_Click" />
            </div>
        </div>
        <div>
            <h3>Details:</h3>
            <asp:GridView ID="gvDetails" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
    </form>
</body>
</html>