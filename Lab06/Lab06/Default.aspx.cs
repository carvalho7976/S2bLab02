using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab06 {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string[] lista = { "Alexandre", "Julia", "Daniel", "Gabriel" };
            Response.Write("Array antes da ordenação<br/>");
            foreach (string nome in lista) {
                Response.Write(nome + " ");
            }
            Response.Write("<br/>");
            Array.Sort(lista);
            Response.Write("Array depois da ordenação<br/>");
            foreach (string nome in lista) {
                Response.Write(nome + " ");
            }
            Response.Write("<br/> ----------------------");
            Pessoa[] lista2 = { new Pessoa("Amanda", 25),
                                  new Pessoa("Mario", 28), 
                                  new Pessoa("Paulo", 20) 
                              };
            Array.Sort(lista2);
            Response.Write("Array depois da ordenação<br/>");
            foreach (Pessoa p in lista2) {
                Response.Write(p.Nome + " ");
            }
            //exercicio 4
            Response.Write("<br/>");
            Array.Sort(lista2, new ComparadorIdadePessoa());
            Response.Write("Array depois da ordenação com comparador<br/>");
            foreach (Pessoa p in lista2) {
                Response.Write(p.Nome + " ");
            }
        }

    }
}