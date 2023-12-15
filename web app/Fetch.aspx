<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fetch.aspx.cs" Inherits="AdvisingSystem.Fetch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fetch Semesters and Courses</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Fetch Semesters and Courses</h2>
            <div>
                <label for="txtSemesterCode">Semester Code:</label>
                <asp:TextBox ID="txtSemesterCode" runat="server" required="true"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnFetchDetails" runat="server" Text="Fetch Details" OnClick="btnFetchDetails_Click" />
            </div>
        </div>
        <div>
            <h3>Details:</h3>
            <asp:GridView ID="gvDetails" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
    </form>
</body>
</html>
