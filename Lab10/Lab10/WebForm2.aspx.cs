using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab10 {
    public partial class WebForm2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["Usuario"] != null) {
                lblSaudacao.Text = "OLA " + Session["Usuario"].ToString();
            }
            else {
                lblSaudacao.Text = "Usuario Desconhecido";
            }
        }
    }
}