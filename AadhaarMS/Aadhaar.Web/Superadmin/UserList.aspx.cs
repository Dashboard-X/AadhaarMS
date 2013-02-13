using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class UserList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        linkNewItem.HRef = NavHelper.GetServerUrl("SUPERAdmin/UserDetails.aspx",true);

        if (!IsPostBack)
        {
            LoadList();
        }
    }

    protected void listRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "delete")
        {
            string id = (string)e.CommandArgument;

            if (string.Equals(id, User.Identity.Name, StringComparison.InvariantCultureIgnoreCase))
                throw new ApplicationException("Cannot delete the current user");

            if (!HasAnyPermissions(id))
            {
                Membership.DeleteUser(id, true);

                LoadList();
            }
            else
            {
                ((IErrorMessage)Master).SetError(GetType(), new Exception("A Permission has been configured to this User. Please delete the permission first."));
   
            }
        }
        else if (e.CommandName == "edit")
        {
            string id = (string)e.CommandArgument;

            NavHelper.Redirect(this,NavHelper.GetServerUrl("SUPERAdmin/UserDetails.aspx",id,true));
        }
    }

    private void LoadList()
    {
        MembershipUserCollection users = Membership.GetAllUsers();

        listRepeater.DataSource = users;
        listRepeater.DataBind();
    }

    protected string GetUserStatus(MembershipUser user)
    {
        if (user.IsApproved == false)
            return "NOT APPROVED";
        else if (user.IsLockedOut)
            return "LOCKED";
        else
            return "Active";
    }

    private bool HasAnyPermissions(string userName)
    {
        foreach (Aadhaar.Data.ViewModel.Permission perm in Aadhaar.Data.ADHSecurityHelper.getAllPermissions())
        {
            if ((!string.IsNullOrEmpty(perm.Users)) && (string.Equals(userName, perm.Users, StringComparison.InvariantCultureIgnoreCase)))
                return true;
        }
        return false;
    }
}
