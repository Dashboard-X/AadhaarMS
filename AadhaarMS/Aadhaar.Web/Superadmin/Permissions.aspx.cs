using System;
using System.Collections.Generic;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Permissions Page for setting up Exclusive Permissions to Webiste Locations
/// </summary>
public partial class Superadmin_Permissions : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ddnRoleNameR.DataSource = System.Web.Security.Roles.GetAllRoles();
            ddnRoleNameR.DataBind();
            
            foreach(Aadhaar.Data.ViewModel.Activities item in Aadhaar.Data.ADHSecurityHelper.getAllActions())
            {
                ddnActionNameR.Items.Add(new ListItem(item.ControllerName+" - "+item.ActionName,item.Id.ToString()));
                ddnActionIdU.Items.Add(new ListItem(item.ControllerName + " - " + item.ActionName, item.Id.ToString()));
                ddnActionNameR.DataBind();
                ddnActionIdU.DataBind();
                

            }
            rptrPermList.DataSource = Aadhaar.Data.ADHSecurityHelper.getAllPermissions();
            rptrPermList.DataBind();
            rptrActionList.DataSource = Aadhaar.Data.ADHSecurityHelper.getAllActions();
            rptrActionList.DataBind();
            
        }

    }

    /// <summary>
    /// Create a Role based Permission
    /// Required Parameter is RoleName as selected from ddnRoleNameR
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnCreateRolePerm_Click(object sender, EventArgs e)
    {
        if(ddnPermissionType.SelectedIndex==-1)
             ((IErrorMessage)Master).SetError(GetType(), new Exception("Please Select the Permission Type"));
        try
        {
            Aadhaar.Data.ViewModel.Permission perm =  new Aadhaar.Data.ViewModel.Permission();
            perm.Roles = ddnRoleNameR.SelectedItem.Text;
            //perm.User=null;
            
            foreach(Aadhaar.Data.ViewModel.Activities item in Aadhaar.Data.ADHSecurityHelper.getAllActions())
            {
                if(ddnActionNameR.SelectedValue==item.Id.ToString())
                {
                    perm.Controller=item.ControllerName;
                    perm.Action=item.ActionName;
                    perm.ControllerId = item.Id;
                }
            }

            Aadhaar.Data.ADHSecurityHelper.CreatePermission(perm);

            Response.Redirect(Request.RawUrl);
        }
        catch (Exception exc)
        {

            ((IErrorMessage)Master).SetError(GetType(), exc);
        }
    }

    /// <summary>
    /// Create a user Based exclusive Permission for a particular location
    /// The Username is to be input in the txtUserId textbox
    /// Please fill in correct User Id only
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnCreateUsrPerm_Click(object sender, EventArgs e)
    {
        if(ddnPermissionType.SelectedIndex==-1)
             ((IErrorMessage)Master).SetError(GetType(), new Exception("Please Select the Permission Type"));
        try
        {
            Aadhaar.Data.ViewModel.Permission perm =  new Aadhaar.Data.ViewModel.Permission();
            perm.Users=txtUserId.Text;
            //perm.Roles=null;
            
            foreach(Aadhaar.Data.ViewModel.Activities item in Aadhaar.Data.ADHSecurityHelper.getAllActions())
            {
                if(ddnActionIdU.SelectedValue==item.Id.ToString())
                {
                    perm.Controller=item.ControllerName;
                    perm.Action=item.ActionName;
                    perm.ControllerId = item.Id;
                }
            }

            Aadhaar.Data.ADHSecurityHelper.CreatePermission(perm);

            Response.Redirect(Request.RawUrl);
        }
        catch (Exception exc)
        {

            ((IErrorMessage)Master).SetError(GetType(), exc);
        }
    }

    /// <summary>
    /// Adds a Location to database for configuration of exclusive permission
    /// ControllerName refers to "Folder" name and "ActionName" refers to "File" Name in our context
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnCreateAction_Click(object sender, EventArgs e)
    {
        try
        {
            //Remove leading and trailing slashes if any
            string trimControllerName = txtAddActionController.Text.TrimStart('/');
            trimControllerName = trimControllerName.TrimEnd('/');

            Aadhaar.Data.ADHSecurityHelper.CreateAction(trimControllerName, txtAddActionAction.Text);
            
            Response.Redirect(Request.RawUrl);
        }
        catch (Exception exc)
        {

            ((IErrorMessage)Master).SetError(GetType(), exc);
        }
    }

    /// <summary>
    /// Binds the Existing Locations as added into the Actions database for configuration of exclusive Permissions
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    protected void rptrActionList_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "deleteAction")
        {
            string id = (string)e.CommandArgument;
            

            try
            {
                int ID = Int32.Parse(id);

                Aadhaar.Data.ADHSecurityHelper.DeleteAction(ID);

                Response.Redirect(Request.RawUrl);
            }
            catch (Exception exc)
            {

                ((IErrorMessage)Master).SetError(GetType(), exc);
            }
        }
    }

    /// <summary>
    /// Deletes a Permission on the basis of Input Id
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    protected void rptrPermList_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "deletePerm")
        {
            string id = (string)e.CommandArgument;


            try
            {
                int ID = Int32.Parse(id);

                Aadhaar.Data.ADHSecurityHelper.DeletePermission(ID);

                Response.Redirect(Request.RawUrl);
            }
            catch (Exception exc)
            {

                ((IErrorMessage)Master).SetError(GetType(), exc);
            }
        }
    }
}