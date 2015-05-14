using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab12a {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            wucLogin1.EventoLogar += new wucLogin.delegateLogin(wucLogin_EventoLogar);
        }
        void wucLogin_EventoLogar(string usuario, string senha) {
            string loginCerto = "rogerio";
            string senhaCerta = "123";
            if (loginCerto.Equals(usuario) && senhaCerta.Equals(senha))
                wucLogin1.AlterarMensgem("login Correto");
            else
                wucLogin1.AlterarMensgem("Login incorreto");
        }
    }
}