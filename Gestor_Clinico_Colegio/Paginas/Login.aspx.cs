﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gestor_Clinico_Colegio.Paginas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Login1_Authenticate1(object sender, AuthenticateEventArgs e)
        {
            Response.Redirect("~/Buscador.aspx");
        }

    }
}