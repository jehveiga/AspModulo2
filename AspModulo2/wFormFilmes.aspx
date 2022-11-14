<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wFormFilmes.aspx.cs" Inherits="AspModulo2.wFormFilmes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Filmes: Insira um novo filme digitando seu nome na caixa de texto"></asp:Label>
            <br />
            <asp:DropDownList runat="server" ID="ddlFilmes"></asp:DropDownList>
            <asp:TextBox ID="tbValor" runat="server" ToolTip="Digite o nome do filme para inserir na sua lista"></asp:TextBox>
            <asp:Button ID="btnInserirNome" runat="server" Text="Inserir" OnClick="btnInserirNome_Click"></asp:Button>
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" PostBackUrl="~/wRespostaFilmes.aspx"></asp:Button>
        </div>
    </form>
</body>
</html>
