using Lab03Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula02 {
    public partial class Movimentacao : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            ContaCorrente minhaConta = new ContaCorrente("Rogerio");
            Response.Write("Movimentações conta: " + minhaConta.Nome + "<br/>");
            Response.Write(minhaConta.Saldo + "<br/>");
            minhaConta.Depositar(100);
            Response.Write(minhaConta.Saldo + "<br/>");
            minhaConta.Sacar(50);
            Response.Write(minhaConta.Saldo + "<br/>");
            Response.Write("Ultima movimentacao " + minhaConta.Data +  "<br/>");
        }
    }
}