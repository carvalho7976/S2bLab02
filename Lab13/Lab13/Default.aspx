<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab13.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
<br />
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
