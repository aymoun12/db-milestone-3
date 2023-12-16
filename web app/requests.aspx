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
            <asp:TextBox ID="courseId" placeholder="Course ID" runat="server"></asp:TextBox>
            <asp:TextBox ID="courseComment" placeholder="Comment" runat="server"></asp:TextBox>
            <asp:Button ID="submitCourseRequest" runat="server" Text="Submit" OnClick="SubmitCourseRequest" />
        </div>
        <br>
        <div>
            <asp:Label runat="server" Text="Credit Hour Requests"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="creditHoursAmount" placeholder="Credit Hours Amount" runat="server"></asp:TextBox>
            <asp:TextBox ID="creditHoursComment" placeholder="Comment" runat="server"></asp:TextBox>
            <asp:Button ID="submitCreditHoursRequest" runat="server" Text="Submit" OnClick="SubmitCreditHoursRequest" />
        </div>
        <br>
        <div>
            <asp:Button ID="back" runat="server" Text="Back" OnClick="Back" />
        </div>
    </form>
</body>
</html>
