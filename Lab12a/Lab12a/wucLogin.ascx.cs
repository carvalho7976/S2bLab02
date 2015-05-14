using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab12a {
    public partial class wucLogin : System.Web.UI.UserControl {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            EventoLogar(txtUsuario.Text, txtSenha.Text);
        }
        public void AlterarMensgem(string mensagem) {
            lblMensagem.Text = mensagem;
        }
        public delegate void delegateLogin(string usuario, string senha);
        public event delegateLogin EventoLogar;
    }
}