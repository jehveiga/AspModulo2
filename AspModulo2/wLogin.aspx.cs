using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspModulo2
{
    public partial class wLogin : System.Web.UI.Page
    {
        List<string> usuários;
        String senhaPadrao = "asp.net2022";
        protected void Page_Load(object sender, EventArgs e)
        {
            usuários= new List<string>();
            usuários.Add("teste1");
            usuários.Add("teste2");
            usuários.Add("teste3");

            if (Request.Cookies["login"] != null)
            {
                txtLogin.Text = Request.Cookies["login"].Value;
                txtPassword.Text = Request.Cookies["password"].Value;
                //btnLogar_Click(sender, e);
            }
        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            Boolean flag = false;
            foreach (var user in usuários)
            {
                if(txtLogin.Text == user && senhaPadrao == txtPassword.Text)
                {
                    HttpCookie login = new HttpCookie("login", txtLogin.Text);
                    Response.Cookies.Add(login);
                    Response.Cookies.Add(new HttpCookie("password", txtPassword.Text));
                    Response.Redirect("~/wPrincipal.aspx");
                }
            }

            Response.Write($"<h2>Usuário ou senha incorreto</h2>");
            return;
        }
    }
}