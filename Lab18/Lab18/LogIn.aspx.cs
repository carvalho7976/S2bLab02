using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;

namespace Lab18 {
    public partial class LogIn : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void butSignOn_Click(object sender, EventArgs e) {
            //Check the user name.
            if (UserExists(txtUserName.Text)) {
                //Check the password (encrypted).
                if (PasswordValid(txtUserName.Text, txtPassword.Text)) {
                    //Sign the user on.
                    FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, true);
                }
                else {
                    //Display an invalid password message.
                    lblStatus.Text = "Password does not match. Try again.";
                }
            }
            else {
                //If user name not found, offer to add it.
                lblStatus.Text = "User name not found. Click Add User to add it now.";
                //Make Add User button visible.
                butAddUser.Visible = true;
            }
            // Keep track of tries.
            ViewState["Tries"] = System.Convert.ToInt32(ViewState["Tries"]) + 1;
            if (System.Convert.ToInt32(ViewState["Tries"]) > 3) {
                Response.Redirect("Denied.htm");
            }
        }
        private bool UserExists(string UserName) {
            //Create a data set to read the XML file.
            DataSet dsUsers = new DataSet();
            //Use error handling in case is file missing.
            try {
                //Build the Users.xml file path.
                string strXMLFile = Server.MapPath(".") + "\\Users.xml";
                //Read the file
                dsUsers.ReadXml(strXMLFile, XmlReadMode.InferSchema);
                //For each row in the Users table.
                foreach (DataRow rowUser in dsUsers.Tables["Users"].Rows) {
                    //Check for name match.
                    if (rowUser["name"].ToString() == UserName) {
                        return true;
                    }
                }
            }
            catch {
                //In case of error return False.
                return false;
            }
            // Otherwise, return false
            return false;
        }
        private bool PasswordValid(string UserName, string Password) {
            //Create a data set to read the XML file.
            DataSet dsUsers = new DataSet();
            //Use error handling in case is file missing.
            try {
                // Build the Users.xml file path.
                string strXMLFile = Server.MapPath(".") + "\\Users.xml";
                // Read the file
                dsUsers.ReadXml(strXMLFile, XmlReadMode.InferSchema);
                // For each row in the Users table.
                foreach (DataRow rowUser in dsUsers.Tables["Users"].Rows) {
                    // Check for name match.
                    if (rowUser["name"].ToString() == UserName) {
                        if (rowUser["password"].ToString() ==
                        FormsAuthentication.HashPasswordForStoringInConfigFile(Password, "SHA1")) {
                            return true;
                        }
                    }
                }
            }
            catch {
                // In case of error return False.
                return false;
            }
            return false;
            
        }

        protected void butAddUser_Click(object sender, EventArgs e) {
            if (AddUser(txtUserName.Text, txtPassword.Text)) {
                //Display success.
                lblStatus.Text = "User added. Click Sign On to continue.";
                //Hide button.
                butAddUser.Visible = false;
            }
            else {
                //Display failure.
                lblStatus.Text = "User could not be added. Choose a different name.";
            }
        }

        private bool AddUser(string UserName, string Password) {
            // If the user already exists, return False and exit.
            if (UserExists(UserName)) {
                return false;
            }
            // Otherwise, add user to XML file.
            DataSet dsUsers = new DataSet();
            // Use error handling in case is file missing.
            try {
                // Build the Users.xml file path.
                string strXMLFile = Server.MapPath(".") +
                "\\Users.xml";
                // Read the file.
                dsUsers.ReadXml(strXMLFile, XmlReadMode.InferSchema);
                // Add a new row.
                DataRow rowUser = dsUsers.Tables["users"].NewRow();
                // Set Username.
                rowUser["name"] = UserName;
                // Set password (encrypted).
                rowUser["password"] =
                FormsAuthentication.HashPasswordForStoringInConfigFile
                (Password, "SHA1");
                // Add row.
                dsUsers.Tables["users"].Rows.Add(rowUser);
                // Write data set.
                dsUsers.WriteXml(strXMLFile);
                return true;
            }
            catch {
                // In case of error return false.
                return false;
            }
        }
    }
}