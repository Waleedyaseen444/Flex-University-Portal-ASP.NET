﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gradesaspx.aspx.cs" Inherits="gradesaspx" %>

<!DOCTYPE html>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Assign Grades</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="StudentID" HeaderText="Student ID" />
                    <asp:BoundField DataField="CourseID" HeaderText="Course ID" />
                    <asp:BoundField DataField="SectionID" HeaderText="Section ID" />
                    <asp:BoundField DataField="Assignment" HeaderText="Assignment" />
                    <asp:BoundField DataField="Quiz" HeaderText="Quiz" />
                    <asp:BoundField DataField="Sessional_I" HeaderText="Sessional I" />
                    <asp:BoundField DataField="Sessional_II" HeaderText="Sessional II" />
                    <asp:BoundField DataField="Project" HeaderText="Project" />
                    <asp:BoundField DataField="Final" HeaderText="Final" />
                    <asp:BoundField DataField="Grade" HeaderText="Grade" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>

