
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewCourse.aspx.cs" Inherits="AdvisingSystem.NewCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add New Course</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Add New Course</h2>
            <div>
                <label for="txtMajor">Major:</label>
                <asp:TextBox ID="txtMajor" runat="server" required="true"></asp:TextBox>
            </div>
            <div>
                <label for="txtSemester">Semester:</label>
                <asp:TextBox ID="txtSemester" runat="server" required="true"></asp:TextBox>
            </div>
            <div>
                <label for="txtCreditHours">Credit Hours:</label>
                <asp:TextBox ID="txtCreditHours" runat="server" required="true" type="number"></asp:TextBox>
            </div>
            <div>
                <label for="txtCourseName">Course Name:</label>
                <asp:TextBox ID="txtCourseName" runat="server" required="true"></asp:TextBox>
            </div>
            <div>
                <label for="chkIsOffered">Is Offered:</label>
                <asp:CheckBox ID="chkIsOffered" runat="server" />
            </div>
            <div>
                <asp:Button ID="btnAddCourse" runat="server" Text="Add Course" OnClick="btnAddCourse_Click" />
            </div>
        </div>
    </form>
</body>
</html>