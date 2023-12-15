<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinkInstructor.aspx.cs" Inherits="AdvisingSystem.LinkInstructor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Link Instructor</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Link Instructor to Course on Specific Slot</h2>
            <div>
                <label for="txtCourseID">Course ID:</label>
                <asp:TextBox ID="txtCourseID" runat="server" required="true" type="number"></asp:TextBox>
            </div>
            <div>
                <label for="txtInstructorID">Instructor ID:</label>
                <asp:TextBox ID="txtInstructorID" runat="server" required="true" type="number"></asp:TextBox>
            </div>
            <div>
                <label for="txtSlotID">Slot ID:</label>
                <asp:TextBox ID="txtSlotID" runat="server" required="true" type="number"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnLinkInstructor" runat="server" Text="Link Instructor" OnClick="btnLinkInstructor_Click" />
            </div>
        </div>
    </form>
</body>
</html>