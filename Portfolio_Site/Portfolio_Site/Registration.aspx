<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Portfolio_Site.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div>
              Username <asp:TextBox ID="txtUser" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            <br />
            <br />
            Password <asp:TextBox ID="txtPass" TextMode="Password" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
              <br />
              <br />
              Confirm Password <asp:TextBox ID="txtPassConf" TextMode="Password" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            <br />

             <asp:Button ID="btnRegister" runat="server" Text="Register" OnClientClick="return validateLogin();" OnClick="btnRegister_Click" />
            <br />
            <br />
            <ul id="errList">

            </ul>
            
        </div>


    <script>
        function validateLogin()
        {
            let result = true;
            let prob = [0, 0, 0, 0];

            let user = document.getElementById('<%= txtUser.ClientID %>').value;
            let pass = document.getElementById('<%= txtPass.ClientID %>').value;
            let passConf = document.getElementById('<%= txtPassConf.ClientID %>').value;

            result = (pass == passConf);
            if (!result) {
                    prob[0] = 1;
                }
            result = true;

                result = (user.length >= 8);
                if (!result) {
                    prob[1] = 1;
                }


            result = true;

                result = (pass.length >= 8);
                if (!result) {
                    prob[2] = 1;
                }


            result = true;

                for (i = 0; i < pass.length; i++)
                {
                    let char = parseInt(pass[i]);
                    if (char) {
                        result = true;
                        break;
                    }
                    else {
                        result = false;

                    }
                }
                if (!result) {
                    prob[3] = 1;
                }
                


            let list = document.getElementById("errList");
            list.innerHTML = "";

            if (prob.indexOf(1) != -1) {

                
                let message;

                if (prob[0] == 1)
                {
                    let doc0 = document.createElement("li");
                    message = "Password and password confirmation did not match.";
                    let node0 = document.createTextNode(message);
                    doc0.appendChild(node0);
                    list.appendChild(doc0);

                }
                if (prob[1] == 1)
                {
                    let doc1 = document.createElement("li");
                    message = "Username is not long enough. It has to be at least 8 characters long.";
                    let node1 = document.createTextNode(message);
                    doc1.appendChild(node1);
                    list.appendChild(doc1);
                }
                if (prob[2] == 1)
                {
                    let doc2 = document.createElement("li");
                    message = "Password is not long enough. It has to be at least 8 characters long.";
                    let node2 = document.createTextNode(message);
                    doc2.appendChild(node2);
                    list.appendChild(doc2);
                }
                if (prob[3] == 1)
                {
                    let doc3 = document.createElement("li");
                    message = "Your password needs to contain at least one number.";
                    let node3 = document.createTextNode(message);
                    doc3.appendChild(node3);
                    list.appendChild(doc3);
                }
                result = false;
            }

            return result;
        }
    </script>

</asp:Content>
