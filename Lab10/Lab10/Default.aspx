<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab10.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>
        <asp:TextBox ID="txtUsuario" runat="server" style="margin-left: 7px"></asp:TextBox>
        <br />
        <asp:Label ID="lblSenha" runat="server" Text="Senha:"></asp:Label>
        <asp:TextBox  ID="txtSenha" runat="server" style="margin-left: 20px" Width="161px" TextMode="Password"></asp:TextBox>
    
        <br />
        <asp:Button ID="btnLogar" runat="server" OnClick="btnLogar_Click" Text="Logar" Width="67px" />
        
        <asp:Button ID="btnLogarComCookies" runat="server" OnClick="btnLogarComCookies_Click" style="margin-left: 13px" Text="LogarComCookies" Width="168px" />
        <br />
        <asp:Label ID="lblMensagem" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
