﻿using System;
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
            lbLogin.Text = String.Empty;
            if (Request.Cookies["login"] != null)
                lbLogin.Text = Request.Cookies["login"].Value;
        }
    }
}