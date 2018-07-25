<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Portfolio_Site.Calculator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="pnlCalc"  runat="server" Height="290px" Width="200px" BorderWidth="3px" BorderStyle="Solid" BorderColor="#DDEEFF" BackColor="#6666FF" OnPreRender="pnlCalc_PreRender" CssClass="leftpush">
             <br />
                <p>Result</p>
                <asp:TextBox ID="txtResult" runat="server" ReadOnly="True"  BorderWidth="4px" BorderColor="#6666FF"></asp:TextBox>

                <br />
                <br />
                <table>
                <tr>
                    <th>
                       <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="71px" /> </th>
                    <th> <asp:Button ID="btnSubtract" runat="server" OnClick="btnSubtract_Click" Text="Subtract" Width="71px" /></th>
                </tr>
                <tr>
                    <th><asp:Button ID="btnMultiply" runat="server" Text="Multiply" OnClick="btnMultiply_Click" Width="71px" /></th>
                    <th><asp:Button ID="btnDivide" runat="server" Text="Divide" OnClick="btnDivide_Click" Width="71px" /></th>
                    
                </tr>
            </table>
                
                <p>Input</p>
                <asp:TextBox ID="txtInput" runat="server" BorderWidth="4px" BorderColor="#6666FF"></asp:TextBox>

                </asp:Panel>
</asp:Content>
