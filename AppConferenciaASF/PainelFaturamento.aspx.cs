﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppConferenciaASF
{
    public partial class PainelFaturamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient nn = new ServiceReference1.WebService1SoapClient();
            this.GridView1.DataSource = nn.ListaPedidosParaFaturar();
            this.GridView1.DataBind();
        }
    }
}