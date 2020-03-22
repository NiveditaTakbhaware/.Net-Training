<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CalculateAss.aspx.cs" Inherits="CalculateAss" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #003300;
            text-decoration: underline;
        }
        .auto-style2 {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style2"><strong><em>&nbsp; </em></strong></span><span class="auto-style1"><strong><em>CALCULATE THE ANSWER...</em></strong></span>.<strong><em><br class="auto-style2" />
        </em></strong>
        <hr />
        <asp:Label ID="Label1" runat="server" Text="number1:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="number2:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" Text="Add" GroupName="cal" />
        <asp:RadioButton ID="RadioButton2" runat="server" Text="subtract" GroupName="cal" />
        <asp:RadioButton ID="RadioButton3" runat="server" Text="multiply" GroupName="cal" />
        <asp:RadioButton ID="RadioButton4" runat="server" Text="divide" GroupName="cal" />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Result:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Width="240px"></asp:TextBox>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
