<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="MachineRound3NIVI.signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 283px;
    }
    .auto-style2 {
        width: 283px;
        height: 77px;
    }
    .auto-style3 {
        height: 77px;
    }
    .auto-style4 {
        width: 283px;
        height: 31px;
    }
    .auto-style5 {
        height: 31px;
    }
    .auto-style6 {
        color: #FF0000;
    }
        .auto-style7 {
            width: 283px;
            height: 39px;
        }
        .auto-style8 {
            height: 39px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="width:100%;">
        <tr>
            <td colspan="2"><span class="auto-style6">Note:- * marked filed are mandatory<br />
                </span>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                <br />
            </td>
           
        </tr>
        <tr>
            <td class="auto-style1"><span class="auto-style6">*</span>First name:-</td>
            <td>
                <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtfname" ForeColor="Red">first name is Required</asp:RequiredFieldValidator>
            &nbsp;&nbsp;
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="only alphabets and space allowed" ForeColor="Red" ValidationExpression="[a-zA-Z ]*$" ControlToValidate="txtfname"></asp:RegularExpressionValidator>
            </td>
           
        </tr>
        <tr>
            <td class="auto-style1"><span class="auto-style6">*</span>Middle name:-</td>
            <td>
                <asp:TextBox ID="txtmname" runat="server"></asp:TextBox>
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="only alphabets and sapce are allowed " ForeColor="Red" ValidationExpression="[a-zA-Z ]*$" ControlToValidate="txtmname"></asp:RegularExpressionValidator>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style1"><span class="auto-style6">*</span>Last name:-</td>
            <td>
                <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
            &nbsp;
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="only alphabets and sapce allowed" ForeColor="Red" ValidationExpression="[a-zA-Z ]*$" ControlToValidate="txtlname"></asp:RegularExpressionValidator>
            </td>
           
        </tr>
          <tr>
            <td class="auto-style7"><span class="auto-style6">*</span>Mobile number:-</td>
            <td class="auto-style8">
                <asp:TextBox ID="txtmobile" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtmobile" ErrorMessage="mobile number must be of 10 digit " ForeColor="Red" ValidationExpression="^\d{10,}$"></asp:RegularExpressionValidator>
              </td>
           
        </tr>
          <tr>
            <td class="auto-style1"><span class="auto-style6">*</span>Email:-</td>
            <td>
                <asp:TextBox ID="txtemail" runat="server" TextMode="Email"></asp:TextBox>
              </td>
           
        </tr>
          <tr>
            <td class="auto-style1"><span class="auto-style6">*</span>Password:-</td>
            <td>
                <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
              </td>
           
        </tr>
        <tr>
            <td class="auto-style1"><span class="auto-style6">*</span>Gender:-</td>
            <td>
                <asp:RadioButton ID="rbtnmale" runat="server" GroupName="gen" Text="Male" />
&nbsp;&nbsp;
                <asp:RadioButton ID="rbtnfemale" runat="server" GroupName="gen" Text="Female" />
            </td>
            
        </tr>
        <tr>
            <td class="auto-style1"><span class="auto-style6">*</span>Date Of Birth:-</td>
            <td>
                <asp:TextBox ID="txtdob" runat="server" AutoPostBack="True" TextMode="Date" OnTextChanged="txtdob_TextChanged"></asp:TextBox>
            &nbsp;</td>
            
        </tr>
        <tr>
            <td class="auto-style4">Age:-</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtage" runat="server"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style1"><span class="auto-style6">*</span>Corresponding address:-</td>
            <td>
                <asp:TextBox ID="txtcaddress" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
           
        </tr>
          <tr>
            <td class="auto-style4"></td>
            <td class="auto-style5">parmanent address same as corresponding&nbsp;&nbsp;
                <asp:CheckBox ID="chbPaddress" runat="server" AutoPostBack="True" Text="Yes" OnCheckedChanged="chbPaddress_CheckedChanged" />
              </td>
           
        </tr>
        <tr>
            <td class="auto-style1"><span class="auto-style6">*</span>Parmanent address:-</td>
            <td>
                <asp:TextBox ID="txtpaddress" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style1"><span class="auto-style6">*</span>Experience:-</td>
            <td>
                <asp:DropDownList ID="ddexperience" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem>6 months</asp:ListItem>
                    <asp:ListItem>1 year</asp:ListItem>
                    <asp:ListItem>2 years</asp:ListItem>
                    <asp:ListItem>3 years</asp:ListItem>
                    <asp:ListItem>4 years</asp:ListItem>
                    <asp:ListItem>5 years</asp:ListItem>
                </asp:DropDownList>
            </td>
           
        </tr>
         <tr>
            <td class="auto-style1"><span class="auto-style6">*</span>Department:-</td>
            <td>
                <asp:RadioButtonList ID="rbtnlistdepartment" runat="server">
                    <asp:ListItem>Marketing</asp:ListItem>
                    <asp:ListItem>Developing</asp:ListItem>
                    <asp:ListItem>Technical support</asp:ListItem>
                    <asp:ListItem>Sales Executive</asp:ListItem>
                </asp:RadioButtonList>
             </td>
           
        </tr>
        <tr>
            <td class="auto-style1">Profile:-</td>
            <td>
                <asp:TextBox ID="txtprofile" runat="server"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style1"><span class="auto-style6">*</span>Knowledge:-</td>
            <td>
                <asp:CheckBoxList ID="chblistknowledge" runat="server">
                    <asp:ListItem>Java</asp:ListItem>
                    <asp:ListItem>Dotnet</asp:ListItem>
                    <asp:ListItem>Python</asp:ListItem>
                    <asp:ListItem>SQL</asp:ListItem>
                    <asp:ListItem>Oracle</asp:ListItem>
                </asp:CheckBoxList>
            </td>
           
        </tr>
         <tr>
            <td class="auto-style2"><span class="auto-style6">*</span>Photo:-</td>
            <td class="auto-style3">
                <asp:FileUpload ID="FileUploadphoto" runat="server" Width="338px" />
             </td>
           
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Image ID="Imagephoto" runat="server" Height="166px" Width="201px" />
            </td>
            
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
&nbsp; &nbsp;
                <asp:Button ID="btnreset" runat="server" Text="Reset" />
&nbsp;&nbsp;
                <asp:Button ID="btnback" runat="server" Text="Back" />
            </td>
           
        </tr>
    </table>

</asp:Content>
