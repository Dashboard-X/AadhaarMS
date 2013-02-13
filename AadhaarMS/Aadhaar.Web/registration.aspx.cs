using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!Page.IsPostBack)
        //{
        //    DropDownList ddnTZ = (DropDownList)CreateUserExWizard1.CreateUserStep.ContentTemplateContainer.FindControl("ddnTimeZone");
        //    ddnTZ.DataSource = TimeZoneInfo.GetSystemTimeZones();
        //    ddnTZ.DataValueField = "Id";
        //    ddnTZ.DataTextField = "DisplayName";
        //    ddnTZ.DataBind();
        //}
    }
    //protected void CreateUserExWizard1_CreatedUser(object sender, EventArgs e)
    //{
    //    if (Page.IsValid)
    //    {
    //        TextBox UserName = (TextBox)CreateUserExWizard1.CreateUserStep.ContentTemplateContainer.FindControl("UserName");
    //        TextBox Email = (TextBox)CreateUserExWizard1.CreateUserStep.ContentTemplateContainer.FindControl("Email");
    //        TextBox Question = (TextBox)CreateUserExWizard1.CreateUserStep.ContentTemplateContainer.FindControl("Question");
    //        TextBox Answer = (TextBox)CreateUserExWizard1.CreateUserStep.ContentTemplateContainer.FindControl("Answer");
    //        TextBox Passwrd = (TextBox)CreateUserExWizard1.CreateUserStep.ContentTemplateContainer.FindControl("Password");

    //        TextBox Name = (TextBox)CreateUserExWizard1.CreateUserStep.ContentTemplateContainer.FindControl("Name");
    //        TextBox Surname = (TextBox)CreateUserExWizard1.CreateUserStep.ContentTemplateContainer.FindControl("Surname");
    //        TextBox Company = (TextBox)CreateUserExWizard1.CreateUserStep.ContentTemplateContainer.FindControl("Company");
    //        TextBox Phone = (TextBox)CreateUserExWizard1.CreateUserStep.ContentTemplateContainer.FindControl("Phone");
    //        TextBox PostalCode = (TextBox)CreateUserExWizard1.CreateUserStep.ContentTemplateContainer.FindControl("PostalCode");
    //        DropDownList ddnTZ = (DropDownList)CreateUserExWizard1.CreateUserStep.ContentTemplateContainer.FindControl("ddnTimeZone");

    //        try
    //        {
    //            // Attempt to register the user
    //            MembershipCreateStatus createStatus;
    //            MembershipUser currentUser = Membership.CreateUser(UserName.Text,Passwrd.Text, Email.Text,Question.Text,Answer.Text,true,null, out createStatus);

    //            if (createStatus == MembershipCreateStatus.Success)
    //            {
    //                setAuthCookie(currentUser);

    //               System.Web.Profile.ProfileBase prof = ProfileCommon.Create(UserName.Text, true);



    //               prof.SetPropertyValue("Name", Name.Text);
    //               prof.SetPropertyValue("Surname", Surname.Text);
    //               prof.SetPropertyValue("Company", Company.Text);
    //               prof.SetPropertyValue("Phone", Phone.Text);
    //               prof.SetPropertyValue("PostalCode", PostalCode.Text);
    //               prof.SetPropertyValue("TimeZone", ddnTZ.SelectedValue);

    //            }
    //            else
    //            {

    //                ((IErrorMessage)Master).SetError(GetType(), new Exception(ErrorCodeToString(createStatus)));

    //            }
    //        }
    //        catch (Exception exc)
    //        {

    //            ((IErrorMessage)Master).SetError(GetType(), exc);
    //        }

    //    }
    //}

    //#region private methods

    //private void setAuthCookie(MembershipUser currentUser)
    //{
    //    //Set Auth cookie
    //    //FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
    //    string userData = String.Empty;
    //    userData = userData + "Email=" + currentUser.Email;
    //    userData += ";UKeyN=" + currentUser.ProviderUserKey.ToString();
    //    userData += ";roleStr=" + string.Join(",", Roles.GetRolesForUser(currentUser.UserName));

    //    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, currentUser.UserName, DateTime.Now, DateTime.Now.AddMinutes(30), true, userData);
    //    string encTicket = FormsAuthentication.Encrypt(ticket);
    //    System.Web.HttpCookie faCookie = new System.Web.HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
    //    Response.Cookies.Add(faCookie);


    //}
    //#endregion

    //#region Status Codes
    //private static string ErrorCodeToString(MembershipCreateStatus createStatus)
    //{
    //    // See http://go.microsoft.com/fwlink/?LinkID=177550 for
    //    // a full list of status codes.
    //    switch (createStatus)
    //    {
    //        case MembershipCreateStatus.DuplicateUserName:
    //            return "User name already exists. Please enter a different user name.";

    //        case MembershipCreateStatus.DuplicateEmail:
    //            return "A user name for that e-mail address already exists. Please enter a different e-mail address.";

    //        case MembershipCreateStatus.InvalidPassword:
    //            return "The password provided is invalid. Please enter a valid password value.";

    //        case MembershipCreateStatus.InvalidEmail:
    //            return "The e-mail address provided is invalid. Please check the value and try again.";

    //        case MembershipCreateStatus.InvalidAnswer:
    //            return "The password retrieval answer provided is invalid. Please check the value and try again.";

    //        case MembershipCreateStatus.InvalidQuestion:
    //            return "The password retrieval question provided is invalid. Please check the value and try again.";

    //        case MembershipCreateStatus.InvalidUserName:
    //            return "The user name provided is invalid. Please check the value and try again.";

    //        case MembershipCreateStatus.ProviderError:
    //            return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

    //        case MembershipCreateStatus.UserRejected:
    //            return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

    //        default:
    //            return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
    //    }
    //}
    //#endregion
}