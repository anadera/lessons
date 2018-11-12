<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge5.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:Image ID="spyImage" runat="server" ImageUrl="~/Capture.PNG" />
        </div>
    	<h1>Spy New Assignment Form</h1>
		<p>
			Spy Code Name:
			<asp:TextBox ID="spyCodeTextBox" runat="server"></asp:TextBox>
		</p>
		<p>
			New Assignment Name:
			<asp:TextBox ID="newAssignmentTextBox" runat="server"></asp:TextBox>
		</p>
		<p>
			End Date of Previous Assignment:<asp:Calendar ID="endDateCalendar" runat="server" OnSelectionChanged="endDateCalendar_SelectionChanged"></asp:Calendar>
		</p>
		<p>
			Start Date of New Assignment:<asp:Calendar ID="startDateCalendar" runat="server"></asp:Calendar>
		</p>
		<p>
			Projected End Date of New Assignment:<asp:Calendar ID="projectedEndCalendar" runat="server"></asp:Calendar>
		</p>
		<p>
			<asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign Spy" />
		</p>
		<p>
			<asp:Label ID="resultLabel" runat="server"></asp:Label>
		</p>
    </form>
</body>
</html>
