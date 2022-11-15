<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wPrincipal.aspx.cs" Inherits="AspModulo2.wPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbLogin" runat="server" Text="Teste"></asp:Label>
            <br />
            <asp:Button ID="btnExecutar" runat="server" Text="Apaga Cookie" OnClick="btnExecutar_Click" />
            <asp:Button ID="btnListar" runat="server" Text="Listar Cookies" OnClick="btnListar_Click" />
        </div>
    </form>
</body>
</html>
