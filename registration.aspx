<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style2 {
            width: 159px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Height="668px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Bus pass<br /> &nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Name:</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">address:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Bus stop:</td>
                    <td>
                        <asp:BulletedList ID="BulletedList1" runat="server">
                            <asp:ListItem>wadi</asp:ListItem>
                            <asp:ListItem>ravinagr</asp:ListItem>
                            <asp:ListItem>buldi</asp:ListItem>
                        </asp:BulletedList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Date:
                        <asp:Label ID="Label1" runat="server" Text="reg.date"></asp:Label>
                    </td>
                    <td>
                        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Bus Type: </td>
                    <td>
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                            <asp:ListItem>AC</asp:ListItem>
                            <asp:ListItem>Non-Ac</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Gender:</td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="register" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        &nbsp;
                        <asp:Label ID="Label2" runat="server" Text="Details:"></asp:Label>
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
