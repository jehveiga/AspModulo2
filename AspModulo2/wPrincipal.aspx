<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wPrincipal.aspx.cs" Inherits="AspModulo2.wPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbLogin" runat="server" Text="Teste"></asp:Label>
            <br />
            <asp:Button ID="btnExecutar" runat="server" Text="Apaga Cookie" OnClick="btnExecutar_Click" />
            <asp:Button ID="btnListar" runat="server" Text="Listar Cookies" OnClick="btnListar_Click" />
            <br />
            <asp:Label ID="lbSessionID" runat="server" Text="Session ID:"></asp:Label>
            <asp:TextBox ID="txtSession" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbContador" runat="server" Text="Contado da Session:"></asp:Label>
            <asp:TextBox ID="txtContador" runat="server"></asp:TextBox>
            <asp:Button ID="btnConts" runat="server" Text="ADD" OnClick="btnConts_Click" />
            <asp:Button ID="btnRemoveS" runat="server" Text="Remover" OnClick="btnRemoveS_Click" />
        </div>
    </form>
</body>
</html>
