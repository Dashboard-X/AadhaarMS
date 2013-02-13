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

public partial class RoleList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
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
            if (!HasAnyPermissions(id))
            {
                Roles.DeleteRole(id, true);

                LoadList();
            }
            else
            {
                ((IErrorMessage)Master).SetError(GetType(), new Exception("A Permission has been configured to this role. Please delete the permission first."));
            }
        }
    }

    protected void btAdd_Click(object sender, EventArgs e)
    {
        try
        {
            Roles.CreateRole(txtName.Text);

            txtName.Text = string.Empty;
            LoadList();
        }
        catch (Exception ex)
        {
            ((IErrorMessage)Master).SetError(GetType(), ex);
        }
    }

    private void LoadList()
    {
        string[] roles = Roles.GetAllRoles();

        listRepeater.DataSource = roles;
        listRepeater.DataBind();
    }

    private bool HasAnyPermissions(string roleName)
    {
        foreach (Aadhaar.Data.ViewModel.Permission perm in Aadhaar.Data.ADHSecurityHelper.getAllPermissions())
        {
            if ((!string.IsNullOrEmpty(perm.Roles)) && (string.Equals(roleName, perm.Roles, StringComparison.InvariantCultureIgnoreCase)))
                return true;
        }
        return false;
    }
}
