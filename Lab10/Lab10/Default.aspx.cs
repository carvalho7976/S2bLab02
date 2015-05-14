using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab10 {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnLogar_Click(object sender, EventArgs e) {
            Session["Usuario"] = txtUsuario.Text;
             Response.Redirect("WebForm2.aspx");
        }

        protected void btnLogarComCookies_Click(object sender, EventArgs e) {
            if (Request.Browser.Cookies) {
                HttpCookie cookieUsuario = new HttpCookie("Usuario");
                cookieUsuario.Value = txtUsuario.Text;
                cookieUsuario.Expires = DateTime.Now.AddHours(1);
                Response.Cookies.Add(cookieUsuario);
                Response.Redirect("WebForm3.aspx");
            } 
        }
    }
}