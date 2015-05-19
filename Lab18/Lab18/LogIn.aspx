<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="Lab18.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="User Name:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="vldUserName" runat="server" ControlToValidate="txtUserName" ErrorMessage="Name is required"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="margin-left: 11px" Width="178px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="vldPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required"></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="butSignOn" runat="server" OnClick="butSignOn_Click" Text="Sing On" />
        <asp:Button ID="butAddUser" runat="server" OnClick="butAddUser_Click" style="margin-left: 21px" Text="add user" />
        <br />
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
    
    </div>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
