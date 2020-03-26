<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wizard.aspx.cs" Inherits="wizard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="1" Height="141px" Width="527px">
            <WizardSteps>
                <asp:WizardStep runat="server" StepType="Complete" title="Step 1">
                    <asp:Label ID="Label2" runat="server" Text="name:"></asp:Label>
                    &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Step 2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label3" runat="server" Text="password:"></asp:Label>
                    &nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep runat="server" StepType="Complete" Title="step 3">
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    <div>
    
    </div>
    </form>
</body>
</html>
