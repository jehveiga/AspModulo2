<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wLogin.aspx.cs" Inherits="AspModulo2.wLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="lbLogin" runat="server" Text="Login"></asp:Label>
                <br />
                <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lbSenha" runat="server" Text="Password"></asp:Label>
                <br />
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <asp:Button Style="margin-top: 10px;" ID="btnLogar" runat="server" Text="Logar" OnClick="btnLogar_Click" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
