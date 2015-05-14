<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucLogin.ascx.cs" Inherits="Lab12a.wucLogin" %>
        <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSenha" runat="server" Text="Senha:"></asp:Label>
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnLogar" runat="server" OnClick="Button1_Click" Text="Logar" />