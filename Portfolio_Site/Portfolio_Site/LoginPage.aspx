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
                    <th><asp:Button ID="btnLogin" runat="server" Text="Login"  OnClick="btnLogin_Click" style="height: 26px" /></th>
                    <th><asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" /></th>
                </tr>

            </table>
            
        </div>

    <script>

    </script>
</asp:Content>
