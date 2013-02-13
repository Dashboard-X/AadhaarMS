using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {

        if (Membership.ValidateUser(txtUsrId.Text,txtUsrPass.Text))
        {

            setAuthCookie(Membership.GetUser(txtUsrId.Text));
            
            FormsAuthentication.RedirectFromLoginPage(txtUsrId.Text, false);
        }
        else
        {
            // Username and or password not found in our database...
            ErrorLabel.Text = "Username / password incorrect. Please login again.";
            ErrorLabel.Visible = true;
        }
       
    }

    #region private methods

    private void setAuthCookie(MembershipUser currentUser)
    {
        //Set Auth cookie
        string userData = String.Empty;
        userData = userData + "Email=" + currentUser.Email;
        userData += ";UKeyN=" + currentUser.ProviderUserKey.ToString();
        userData += ";roleStr=" + string.Join(",", Roles.GetRolesForUser(currentUser.UserName));

        FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, currentUser.UserName, DateTime.Now, DateTime.Now.AddMinutes(30), true, userData);
        string encTicket = FormsAuthentication.Encrypt(ticket);
        HttpCookie faCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
        Response.Cookies.Add(faCookie);

    }
    #endregion
}
