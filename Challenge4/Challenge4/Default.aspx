<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge4.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF0000;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
            <asp:Image ID="Image1" runat="server" Height="193px" ImageUrl="~/povar.png" Width="158px" /><span class="auto-style2">Papa Bob&#39;s Pizza and Software</span></h1>
            <p>
                <asp:RadioButtonList ID="SizeRadioButtonList" runat="server" OnSelectedIndexChanged="SizeRadioButtonList_SelectedIndexChanged">
                    <asp:ListItem Value="10">Baby Bob Size (10&#39;&#39;) - $10</asp:ListItem>
                    <asp:ListItem Value="13">Mama Bob Size (13&#39;&#39;) - $13</asp:ListItem>
                    <asp:ListItem Selected="True" Value="15">Papa Bob Size (15&#39;&#39;) - $15</asp:ListItem>
                </asp:RadioButtonList>
            </p>
        </div>
        <asp:RadioButtonList ID="CrustRadioButtonList" runat="server" OnSelectedIndexChanged="CrustRadioButtonList_SelectedIndexChanged">
            <asp:ListItem Value="0">Thin Crust</asp:ListItem>
            <asp:ListItem Selected="True" Value="2">Deep Dish (+$2)</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:CheckBoxList ID="ToppingCheckBoxList" runat="server" OnSelectedIndexChanged="ToppingCheckBoxList_SelectedIndexChanged">
            <asp:ListItem Value="1.5">Pepperoni (+$1.50)</asp:ListItem>
            <asp:ListItem Value="0.75">Onions (+$0.75)</asp:ListItem>
            <asp:ListItem Value="0.50">Green Peppers (+$0.50)</asp:ListItem>
            <asp:ListItem Value="0.75">Red Peppers (+$0.75)</asp:ListItem>
            <asp:ListItem Value="2"> Anchovies (+$2)</asp:ListItem>
        </asp:CheckBoxList>
        <h2><span class="auto-style2">Papa Bob&#39;s </span><span class="auto-style1">Special Deal</span></h2>
        <p>
            Save $2 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza.</p>
        <p>
            <asp:Button ID="resultButton" runat="server" Text="Purchase" OnClick="resultButton_Click" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server" Text="Total: $0.00"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text=" Sorry, at this time you can only order one pizza, and pick-up only... we need a better web-site!"></asp:Label>
        </p>
    </form>
</body>
</html>
