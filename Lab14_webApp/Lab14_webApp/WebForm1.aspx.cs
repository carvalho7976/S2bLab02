﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab14_webApp {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            ServiceReference1.IService1 ws = new ServiceReference1.Service1Client();
            lblResultado.Text = ws.SimpleMethod(TextBox1.Text);
        }

        protected void Button2_Click(object sender, EventArgs e) {
            ServiceReference1.IService1 ws = new ServiceReference1.Service1Client();
            grvResultado.DataSource = ws.ComplexMethod();
            grvResultado.DataBind();
        }
    }
}