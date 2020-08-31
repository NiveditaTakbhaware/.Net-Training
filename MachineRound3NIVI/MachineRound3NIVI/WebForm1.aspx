<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MachineRound3NIVI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            email:-
            <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            <br />
            <br />
            password:-
            <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            photo:-
            <asp:FileUpload ID="fileuploadphoto" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="userImage" runat="server" Width="154px" />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnok" runat="server" OnClick="btnok_Click" Text="ok" />
&nbsp;
            <br />
            <br />
            <asp:Label ID="lblstatus" runat="server" Text="status:-"></asp:Label>
        </div>
    </form>
</body>
</html>
