<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Lab13b.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <ajaxtoolkit:toolkitscriptmanager runat="Server" />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <ajaxtoolkit:calendarextender runat="server" targetcontrolid="TextBox1" />
        </div>
    </form>
</body>
</html>
