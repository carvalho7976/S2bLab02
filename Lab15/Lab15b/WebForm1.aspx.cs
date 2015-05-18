using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab15b {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            String conexString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["AdvWorks"].ConnectionString;
            System.Data.SqlClient.SqlConnection conexao = new System.Data.SqlClient.SqlConnection(conexString);
            System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from Production.Product";
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(comando);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "Produtos");
            GridView1.DataSource = ds;
            GridView1.DataMember = "Produtos";
            GridView1.DataBind();
        }
    }
}