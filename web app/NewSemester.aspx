<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewSemester.aspx.cs" Inherits="AdvisingSystem.NewSemester" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add New Semester</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Add New Semester</h2>
            <div>
                <label for="txtStartDate">Start Date:</label>
                <asp:TextBox ID="txtStartDate" runat="server" TextMode="Date" required="true"></asp:TextBox>
            </div>
            <div>
                <label for="txtEndDate">End Date:</label>
                <asp:TextBox ID="txtEndDate" runat="server" TextMode="Date" required="true"></asp:TextBox>
            </div>
            <div>
                <label for="txtSemesterCode">Semester Code:</label>
                <asp:TextBox ID="txtSemesterCode" runat="server" required="true"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnAddSemester" runat="server" Text="Add Semester" OnClick="btnAddSemester_Click" />
            </div>
        </div>
    </form>
</body>
</html>