using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspModulo2
{
    public partial class wRespostaSalarioMinimo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // -- Exemplos de escrita no HTML --
            //Response.Write("<h2> Objeto Request </h2>");
            //Response.Write("<h3> txtSalario: "+ Request.Form["txtSalario"] +" </h3>");
            //Response.Write("<h3> txtPercentual: " + Request.Form["txtPercentualDesconto"] + " </h3>");

            if (Request["txtSalario"] == null)
                Response.Redirect("~/wfSalarioMinimo.aspx");

            Double salarioBase = Convert.ToDouble(Request.Form["txtSalario"]);
            Double percDesconto = 0;

            // Page.PreviousPage - Para obter a Page (dados/controle) que transferiu para a página atual 
            RadioButtonList radioBtn = (RadioButtonList)Page.PreviousPage.FindControl("rblPorcentagem");
            if (radioBtn.SelectedIndex != 3)
            {
                switch (radioBtn.SelectedIndex)
                {
                    case 0:
                        percDesconto = 10;
                        break;
                    case 1:
                        percDesconto = 20;
                        break;
                    case 2:
                        percDesconto = 30;
                        break;
                }
            }
            else
            {
                percDesconto = Convert.ToDouble(Request.Form["txtPercentualDesconto"]);
            }

            // Request.Form - Para obter a coleção de dados que foi submetido do formulário, através de cada controle
            Double desconto = (salarioBase * percDesconto) / 100;
            Double salarioLiquido = salarioBase - desconto;

            Table tabela = new Table();

            //Salario Bruto
            TableRow linha = new TableRow();
            //Texto
            TableCell coluna = new TableCell();
            coluna.Text = "Salário Bruto";
            linha.Cells.Add(coluna);
            //valor
            coluna = new TableCell();
            coluna.Text = salarioBase.ToString();
            linha.Cells.Add(coluna);
            tabela.Rows.Add(linha);

            //Percentual de desconto
            linha = new TableRow();
            //Texto
            coluna = new TableCell();
            coluna.Text = "Percentual de desconto";
            linha.Cells.Add(coluna);
            //valor
            coluna = new TableCell();
            coluna.Text = percDesconto.ToString();
            linha.Cells.Add(coluna);
            tabela.Rows.Add(linha);

            //Salário Líquido 
            linha = new TableRow();
            //Texto
            coluna = new TableCell();
            coluna.Text = "Salário Líquido";
            linha.Cells.Add(coluna);
            //valor
            coluna = new TableCell();
            coluna.Text = salarioLiquido.ToString();
            linha.Cells.Add(coluna);
            tabela.Rows.Add(linha);

            PlaceHolderCalculo.Controls.Add(tabela);
        }
    }
}