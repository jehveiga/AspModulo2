using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspModulo2
{
    public partial class wPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                lbLogin.Text = String.Empty;
                if (Request.Cookies["login"] != null)
                    lbLogin.Text = Request.Cookies["login"].Value;
            }
        }

        protected void btnExecutar_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["login"] != null)
            {
                //Request.Cookies.Clear(); //Método para limpar os  cookie salvos
                Request.Cookies.Remove("login"); //-- Método para limpar um cookie especifico em uma coleção de Cookie --
                int n = Request.Cookies.Count;
            }
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            var keys = Request.Cookies.AllKeys; // Propriedade para obter todos valores/nomes das chaves do Cookie
            String texto = "<p>";
            String pos = String.Empty;
            for (int i = 0; i < Request.Cookies.Count; i++) // For percorrendo pela a quantidade de Cookies cadastrados
            {
                pos = keys[i]; // Obtendo cada key que contem dentro da coleção obtida do array
                texto += $"{pos}: {Request.Cookies[pos].Value}</p>"; // obtendo o valor especificado pelo nome da chave obtida anteriormente
            }
            Response.Write(texto); // Escreve na página o texto forncecido no cado em HTML
        }
    }
}