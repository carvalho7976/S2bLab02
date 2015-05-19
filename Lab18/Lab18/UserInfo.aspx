<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="Lab18.UserInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Forms Authorization</h2>
            <table id="tblUser" cellspacing="1" cellpadding="1" width="500"
                border="1">
                <tr>
                    <td>Authenticated
                    </td>
                    <td>
                        <span id="spnAuthenticated" runat="server"></span>
                    </td>
                </tr>
                <tr>
                    <td>User name
                    </td>
                    <td>
                        <span id="spnUserName" runat="server"></span>
                    </td>
                </tr>
                <tr>
                    <td>Authentication type
                    </td>
                    <td>
                        <span id="spnAuthenticationType" runat="server"></span>
                    </td>
                </tr>
                <tr>
                    <td>Code running as user
                    </td>
                    <td>
                        <span id="spnImpUser" runat="server"></span>
                    </td>
                </tr>
            </table>
            <p>
                <asp:Button ID="butSignOut" runat="server" Text="Sign Out" OnClick="butSignOut_Click"></asp:Button>
            </p>

        </div>
    </form>
</body>
</html>
