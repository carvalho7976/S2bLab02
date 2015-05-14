using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab13 {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(TextBox1.Text)) {
                ListBox1.Items.Add(TextBox1.Text);
                UpdatePanel1.Update();
            }
        }
    }
}