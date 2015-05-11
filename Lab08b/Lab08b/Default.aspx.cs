using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab08b {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            
        }

        protected void btnEnviar_Click(object sender, EventArgs e) {
            Page.Validate();
            if (Page.IsValid) {
                lblMsg.Text = "Procesamento Hmmmmmm OK...";
            }
            else {
                lblMsg.Text = "Erro no Processamento dos dados, por favor morra!";
            }
        }
    }
}