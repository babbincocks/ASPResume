<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Portfolio_Site.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username <asp:TextBox ID="txtUser" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            <br />
            <br />
            Password <asp:TextBox ID="txtPass" TextMode="Password" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            <br />
            <table>
                <tr>
                    <th><asp:Button ID="btnLogin" runat="server" Text="Login"  OnClick="btnLogin_Click" /></th>
                    <th><asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" /></th>
                </tr>

            </table>
            
        </div>
    </form>
</body>
</html>
