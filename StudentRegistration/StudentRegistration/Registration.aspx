<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="StudentRegistration.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;<span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/studentlist.aspx">student list</asp:HyperLink>
            &nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registration.aspx">Register</asp:HyperLink>
&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/login.aspx">login</asp:HyperLink>
            &nbsp;&nbsp;
            <br />
            <br />
            <br />
            *</span> First Name:-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="320px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="First name is required" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBox1" ErrorMessage="Only alphabets and space allowed" ForeColor="Red" ValidationExpression="[a-zA-Z ]*$"></asp:RegularExpressionValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp; Middle Name:-&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Width="297px"></asp:TextBox>
&nbsp;
            <br />
            <br />
&nbsp;<span class="auto-style1">*</span> Last Name:-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Width="274px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="Last name is required" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TextBox3" ErrorMessage="Only alphabets and space allowed" ForeColor="Red" ValidationExpression="[a-zA-Z ]*$"></asp:RegularExpressionValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;<span class="auto-style1">*</span> Mobile Number:-
            <asp:TextBox ID="TextBox4" runat="server" Width="309px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox4" ErrorMessage="Mobile number is required" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage="Please enter 10 digit mobile number" ForeColor="Red" ValidationExpression="^\d{10,}$"></asp:RegularExpressionValidator>
            <br />
            <br />
            <span class="auto-style1">*</span>UserName/Email id:-
            <asp:TextBox ID="TextBox11" runat="server" OnTextChanged="TextBox11_TextChanged" TextMode="Email" Width="291px"></asp:TextBox>
&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox11" ErrorMessage="User name is required" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox11" ErrorMessage="incorrect Email id" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <br />
            <span class="auto-style1">*</span> Gender:-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gen" Text="Female" />
&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gen" Text="Male" />
&nbsp;
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="gen" Text="Others" />
&nbsp;
            <br />
            <br />
            <span class="auto-style1">*</span> Date of Birth :-&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" TextMode="Date" AutoPostBack="True" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="Date of Birth required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Age:-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server" Enabled="False" ReadOnly="True" OnTextChanged="TextBox6_TextChanged"></asp:TextBox>
            <br />
            <br />
            <span class="auto-style1">*</span>Corresponding Address:-
            <asp:TextBox ID="TextBox7" runat="server" OnTextChanged="TextBox7_TextChanged" TextMode="MultiLine" Width="333px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox7" ErrorMessage=" Corresponding Address is  Required" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;
            <br />
            <br />
            Parmanent address same as&nbsp; corresponding address
            <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Yes" AutoPostBack="True" />
            <br />
            <br />
            <span class="auto-style1">*</span> Parmanent Address:-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox8" runat="server" TextMode="MultiLine" Width="326px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox8" ErrorMessage="Parmanent Address is Required" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;
            <br />
            <br />
            <span class="auto-style1">*</span>City:-&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Akola</asp:ListItem>
                <asp:ListItem>Nagpur</asp:ListItem>
                <asp:ListItem>Yavatmal</asp:ListItem>
                <asp:ListItem>Pune</asp:ListItem>
                <asp:ListItem>Mumbai</asp:ListItem>
            </asp:DropDownList>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Please select City" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <span class="auto-style1">*</span>State:-&nbsp;&nbsp;
            <asp:TextBox ID="TextBox9" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
&nbsp;
            <br />
            <br />
            <span class="auto-style1">*</span> Pin Code :-&nbsp;
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox10" ErrorMessage="Please enter Pin code" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox10" ErrorMessage="please enter 6 digit pin code" ForeColor="Red" ValidationExpression="^\d{6,}$"></asp:RegularExpressionValidator>
            <br />
            <br />
            <span class="auto-style1">*</span> Course:-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem>Java</asp:ListItem>
                <asp:ListItem>.Net</asp:ListItem>
                <asp:ListItem>Python</asp:ListItem>
                <asp:ListItem>Php</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <span class="auto-style1">*</span> Stream:-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="Please Select Stream " ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>MCA</asp:ListItem>
                <asp:ListItem>Bsc IT</asp:ListItem>
                <asp:ListItem>Bsc CS</asp:ListItem>
                <asp:ListItem>BCA</asp:ListItem>
                <asp:ListItem>Engineeing IT/CS/CT</asp:ListItem>
            </asp:RadioButtonList>
            <br class="auto-style1" />
            <span class="auto-style1">* </span>Photo:-
            <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;&nbsp;
            <br />
&nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" Height="185px" Width="195px" />
            &nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text=" create password" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
