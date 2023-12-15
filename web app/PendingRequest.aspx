
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PendingRequest.aspx.cs" Inherits="AdvisingSystem.PendingRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pending Requests</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Pending Requests</h2>
            <asp:GridView ID="gvPendingRequests" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="request_id" HeaderText="Request ID" SortExpression="request_id" />
                    <asp:BoundField DataField="type" HeaderText="Type" SortExpression="type" />
                    <asp:BoundField DataField="comment" HeaderText="Comment" SortExpression="comment" />
                    <asp:BoundField DataField="status" HeaderText="Status" SortExpression="status" />
                    <asp:BoundField DataField="credit_hours" HeaderText="Credit Hours" SortExpression="credit_hours" />
                    <asp:BoundField DataField="course_id" HeaderText="Course ID" SortExpression="course_id" />
                    <asp:BoundField DataField="student_id" HeaderText="Student ID" SortExpression="student_id" />
                    <asp:BoundField DataField="advisor_id" HeaderText="Advisor ID" SortExpression="advisor_id" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>