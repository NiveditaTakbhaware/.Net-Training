<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wizard2.aspx.cs" Inherits="wizard2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="1" Height="179px" OnFinishButtonClick="Wizard1_FinishButtonClick" Width="549px">
            <WizardSteps>
                <asp:WizardStep runat="server" title="Step 1">
                    &nbsp;&nbsp;&nbsp;&nbsp; name:&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Step 2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; password:&nbsp;<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep runat="server" StepType="Complete" Title="step 3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label1" runat="server" Text="details:"></asp:Label>
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    
    </div>
    </form>
</body>
</html>
