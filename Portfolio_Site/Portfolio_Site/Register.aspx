<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Portfolio_Site.Register" %>

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
              <br />
              Confirm Password<asp:TextBox ID="txtPassConf" TextMode="Password" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            <br />

             <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />

            
        </div>
    </form>
</body>
</html>
