using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspModulo2
{
    public partial class wFormFilmes : System.Web.UI.Page
    {
        public List<String> Filmes { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInserirNome_Click(object sender, EventArgs e)
        {
            ddlFilmes.Items.Add(new ListItem(tbValor.Text, tbValor.Text));
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Filmes = new List<string>();
            foreach (ListItem filme in ddlFilmes.Items)
            {
                Filmes.Add(filme.Text);
            }

            //Response.Redirect("~/wRespostaFilmes.aspx");
        }
    }
}