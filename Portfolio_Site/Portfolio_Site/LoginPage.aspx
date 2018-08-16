<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Portfolio_Site.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            Username <asp:TextBox ID="txtUser" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            <br />
            <br />
            Password <asp:TextBox ID="txtPass" TextMode="Password" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            <br />
            <table>
                <tr>
                    <th><asp:Button ID="btnLogin" runat="server" Text="Login" OnClientClick="return validLogin();"  OnClick="btnLogin_Click" style="height: 26px" /></th>
                    <th><asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" /></th>
                </tr>

            </table>
            
        </div>

    <script>
        function validLogin() {
            let user = document.getElementById('<%= txtUser.ClientID %>').value;
            let pass = document.getElementById('<%= txtPass.ClientID %>').value;

            let result = true;

            if (!user) {
                Response.Write("You need to put in a username.");
                result = false;
            }
            else if (!pass) {
                Response.Write("You need to put in a password.");
                result = false;
            }

            return result;
        }
    </script>
</asp:Content>
