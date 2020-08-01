<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="password.aspx.cs" Inherits="StudentRegistration.password" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 81%;
            margin-left: 205px;
        }
        .auto-style2 {
            width: 220px;
        }
        .auto-style3 {
            width: 295px;
        }
        .auto-style4 {
            color: #FF0000;
        }
        .auto-style5 {
            width: 220px;
            height: 54px;
        }
        .auto-style6 {
            width: 295px;
            height: 54px;
        }
        .auto-style7 {
            height: 54px;
        }
        .auto-style8 {
            width: 220px;
            height: 58px;
        }
        .auto-style9 {
            width: 295px;
            height: 58px;
        }
        .auto-style10 {
            height: 58px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;
            <table class="auto-style1">
                <tr>
                    <td class="auto-style8">&nbsp;<span class="auto-style4">*</span>Username/Emailid:-</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="TextBox1" runat="server" Width="288px"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ClientIDMode="AutoID" ControlToValidate="TextBox1" ErrorMessage="username Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"><span class="auto-style4">*</span>Password:-</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="287px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="password Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="password must Minimum 8 characters at least 1 Uppercase Alphabet, 1 Lowercase Alphabet, 1 Number and 1 Special Character " ForeColor="Red" ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&amp;])[A-Za-z\d$@$!%*?&amp;]{8,}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"><span class="auto-style4">*</span>Confirm Password:-</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Width="284px"></asp:TextBox>
                    </td>
                    <td class="auto-style7">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="confirm password Required" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="password does not match" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <br />
&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label1" runat="server" Text="status"></asp:Label>
                        <br />
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" Text="Cancel" />
&nbsp;&nbsp;&nbsp; </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
