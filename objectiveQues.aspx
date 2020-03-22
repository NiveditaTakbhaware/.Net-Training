<%@ Page Language="C#" AutoEventWireup="true" CodeFile="objectiveQues.aspx.cs" Inherits="objectiveQues" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: justify;
        }
        .auto-style2 {
            width: 100%;
            border-style: solid;
            border-width: 2px;
        }
        .auto-style3 {
            width: 83px;
            background-color: #FFFFFF;
        }
        .auto-style4 {
            width: 83px;
            height: 23px;
            background-color: #FFFFFF;
        }
        .auto-style5 {
            height: 23px;
            background-color: #FFFFFF;
        }
        .auto-style6 {
            background-color: #CCFFFF;
        }
        .auto-style7 {
            text-decoration: underline;
            font-size: xx-large;
        }
        .auto-style8 {
            background-color: #FFFFFF;
        }
    </style>
</head>
<body style="height: 334px">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <span class="auto-style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span><span class="auto-style6"><span class="auto-style7"><strong><em><span class="auto-style8">QUIZ</span></em></strong></span></span><br class="auto-style8" />
        <br class="auto-style8" />
        <br class="auto-style8" />
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">Question 1:-</td>
                <td class="auto-style8">&nbsp; what is .Net is </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td><span class="auto-style8">&nbsp; &nbsp;</span><asp:RadioButton ID="RadioButton1" runat="server" CssClass="auto-style8" GroupName="q1" Text="Programming Language" />
                    <span class="auto-style8">&nbsp;&nbsp; </span>
                    <asp:RadioButton ID="RadioButton2" runat="server" CssClass="auto-style8" GroupName="q1" Text="Platform" />
                    <span class="auto-style8">&nbsp;&nbsp; </span></td>
            </tr>
            <tr>
                <td class="auto-style4">Question 2:-</td>
                <td class="auto-style5">&nbsp; IIS is what kind of server?&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td><span class="auto-style8">&nbsp;&nbsp;&nbsp; &nbsp;</span><asp:RadioButton ID="RadioButton3" runat="server" CssClass="auto-style8" GroupName="q2" Text="web server" />
                    <span class="auto-style8">&nbsp;&nbsp; </span>
                    <asp:RadioButton ID="RadioButton4" runat="server" CssClass="auto-style8" GroupName="q2" Text="database server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Question 3:-</td>
                <td class="auto-style8">&nbsp; .Net use only C# &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td><span class="auto-style8">&nbsp;&nbsp; &nbsp;</span><asp:RadioButton ID="RadioButton5" runat="server" CssClass="auto-style8" GroupName="q3" Text="True" />
                    <span class="auto-style8">&nbsp;&nbsp; </span>
                    <asp:RadioButton ID="RadioButton6" runat="server" CssClass="auto-style8" GroupName="q3" Text=" false" />
                </td>
            </tr>
            <tr>
                <td colspan="2"><span class="auto-style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</span><asp:Button ID="Button1" runat="server" CssClass="auto-style8" OnClick="Button1_Click" Text="Submit" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Result:-</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="377px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
            </tr>
        </table>
        <br class="auto-style8" />
        <br class="auto-style8" />
        <br class="auto-style6" />
        <br class="auto-style6" />
        <br class="auto-style6" />
        <br class="auto-style6" />
    
    </div>
    </form>
</body>
</html>
