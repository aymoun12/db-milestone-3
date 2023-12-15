<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinkAdvisor.aspx.cs" Inherits="AdvisingSystem.LinkAdvisor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Link Advisor</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Link Student to Advisor</h2>
            <div>
                <label for="txtStudentID">Student ID:</label>
                <asp:TextBox ID="txtStudentID" runat="server" required="true" type="number"></asp:TextBox>
            </div>
            <div>
                <label for="txtAdvisorID">Advisor ID:</label>
                <asp:TextBox ID="txtAdvisorID" runat="server" required="true" type="number"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnLinkAdvisor" runat="server" Text="Link Student" OnClick="btnLinkAdvisor_Click" />
            </div>
        </div>
    </form>
</body>
</html>