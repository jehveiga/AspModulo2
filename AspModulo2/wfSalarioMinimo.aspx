<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfSalarioMinimo.aspx.cs" Inherits="AspModulo2.wfSalarioMinimo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lbSalarioBruto" runat="server" Text="Informe o Salário Bruto"></asp:Label>
            <br />
            <asp:TextBox ID="txtSalario" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbPercDesconto" runat="server" Text="Percentual de desconto"></asp:Label>
            <br />
            <asp:RadioButtonList ID="rblPorcentagem" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Value="10" Selected="True">10 %</asp:ListItem>
                <asp:ListItem Value="20">20 %</asp:ListItem>
                <asp:ListItem Value="30">30 %</asp:ListItem>
                <asp:ListItem>Outro</asp:ListItem>
            </asp:RadioButtonList>
            <asp:TextBox ID="txtPercentualDesconto" runat="server" Visible="False"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar Dados" PostBackUrl="~/wRespostaSalarioMinimo.aspx" />
        </div>
    </form>
</body>
</html>
