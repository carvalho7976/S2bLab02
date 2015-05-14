using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab10 {
    public partial class WebForm3 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            System.Collections.Specialized.NameValueCollection settings =
                System.Web.Configuration.WebConfigurationManager.AppSettings;
            bool isValid = false;
            if (settings.Count > 0) {
                if (!String.IsNullOrEmpty(settings["cookieKey"])) {
                    if (Request.Cookies["Usuario"] != null) {
                        isValid = true;
                        lblSaudacao.Text = "Ola " + Request.Cookies["Usuario"].Value;
                    }
                }
            }
            if (!isValid) lblSaudacao.Text = "Ola Usuario desconhecido";

        }
    }
}