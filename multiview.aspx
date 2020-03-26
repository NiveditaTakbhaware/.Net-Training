<%@ Page Language="C#" AutoEventWireup="true" CodeFile="multiview.aspx.cs" Inherits="wizard" %>

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
            width: 115px;
        }
        .auto-style3 {
            width: 100%;
        }
        .auto-style5 {
            width: 131px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="Login" />
&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="signup" />
&nbsp;<asp:MultiView ID="bus_pass" runat="server">
            <br />
            <asp:View ID="login" runat="server">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2">Username:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">Password:</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    </tr>
                </table>
            </asp:View>
            <br />
            <asp:View ID="Signup" runat="server">
                <table class="auto-style3">
                    <tr>
                        <td class="auto-style5">Name:</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">Email:</td>
                        <td>
                            <asp:TextBox ID="TextBox4" runat="server" TextMode="Email"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    </tr>
                </table>
            </asp:View>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:MultiView>
    
    </div>
    </form>
</body>
</html>
