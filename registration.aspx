<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
        }
        .auto-style2 {
            font-size: large;
        }
        .auto-style3 {
            width: 100%;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style4 {
            width: 105px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="color: #009999; text-align: left; height: 36px; background-color: #CCFF99">
    
        <strong><em><span class="auto-style1"><span class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; BUS PASS SYSTEM</span></span><br class="auto-style1" />
        </em></strong>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
    
    </div>
        <table class="auto-style3">
            <tr>
                <td class="auto-style4">Name:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Address:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Mobile</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">country:</td>
                <td>
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="india" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">city:</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                        <asp:ListItem>Nagpur</asp:ListItem>
                        <asp:ListItem>Amravati</asp:ListItem>
                        <asp:ListItem>Mumbai</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Source:</td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
                        <asp:ListItem>Wadi</asp:ListItem>
                        <asp:ListItem>Campus Square</asp:ListItem>
                        <asp:ListItem>RaviNagar</asp:ListItem>
                        <asp:ListItem>Bhole petrolpump</asp:ListItem>
                        <asp:ListItem>Buldi</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Destination:</td>
                <td>
                    <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True">
                        <asp:ListItem>CampusSquare</asp:ListItem>
                        <asp:ListItem>Ravinagar</asp:ListItem>
                        <asp:ListItem>Bhole</asp:ListItem>
                        <asp:ListItem>Buldi</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">PaymentMode: </td>
                <td>
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="pay" Text="Cash" />
&nbsp;
                    <asp:RadioButton ID="RadioButton3" runat="server" GroupName="pay" OnCheckedChanged="RadioButton3_CheckedChanged" Text="online" />
&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
&nbsp;&nbsp;&nbsp;
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="status"></asp:Label>
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
