<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStudents.aspx.cs" Inherits="AdvisingSystem.ViewStudents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Students</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>View Students</h2>
            <asp:GridView ID="gvStudents" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="student_id" HeaderText="Student ID" SortExpression="student_id" />
                    <asp:BoundField DataField="f_name" HeaderText="First Name" SortExpression="f_name" />
                    <asp:BoundField DataField="l_name" HeaderText="Last Name" SortExpression="l_name" />
                    <asp:BoundField DataField="advisor_id" HeaderText="Advisor ID" SortExpression="advisor_id" />
                    <asp:BoundField DataField="advisor_name" HeaderText="Advisor Name" SortExpression="advisor_name" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>