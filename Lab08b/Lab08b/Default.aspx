<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab08b.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblNome" runat="server" Text="Nome:"></asp:Label>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvNome" runat="server" ControlToValidate="txtNome" Display="None" ErrorMessage="Campo NOME obrigatorio">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblTelefone" runat="server" Text="Telefone:"></asp:Label>
        <asp:TextBox ID="txtTelenone" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="revTelefone" runat="server" ControlToValidate="txtTelenone" Display="None" ErrorMessage="Telefone invalido" ValidationExpression="(\(\d{3}\)|\d{3}-)?\d{8}">*</asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="E-mail invalido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="lblEndereco" runat="server" Text="Endereco:"></asp:Label>
        <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvEndereco" runat="server" ControlToValidate="txtEndereco" Display="None" ErrorMessage="Endereco obrigatorio">*</asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Enviar" />
        <br />
        <br />
        <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
