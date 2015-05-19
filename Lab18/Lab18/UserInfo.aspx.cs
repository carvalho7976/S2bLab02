using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab18 {
    public partial class UserInfo : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            // Display user authentication information.
            spnAuthenticated.InnerText = User.Identity.IsAuthenticated.ToString();
            spnUserName.InnerText = User.Identity.Name;
            spnAuthenticationType.InnerText = User.Identity.AuthenticationType;
            spnImpUser.InnerText =
            System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }

        protected void butSignOut_Click(object sender, EventArgs e) {
            // Remove authentication cookie.
            System.Web.Security.FormsAuthentication.SignOut();
            // Redirect back to this page (displays log in screen).
            Response.Redirect("UserInfo.aspx");
        }
    }
}