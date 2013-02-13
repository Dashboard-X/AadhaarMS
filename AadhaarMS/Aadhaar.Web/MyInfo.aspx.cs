using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyInfo : System.Web.UI.Page
{
    

    string connectionString = "";
    MembershipUser user;
    protected void Page_Load(object sender, EventArgs e)
    {
        //CheckInstalled();
        if (!Page.IsPostBack)
        {
            fetchUserInfo(HttpContext.Current.User.Identity.Name);

            //Profile provider seems to be giving some errors as of now hence excluded.
            fetchProfile(HttpContext.Current.User.Identity.Name);
        }


    }



    //private void CheckInstalled()
    //{

    //    NHibernate.Cfg.Configuration cfg = new NHibernate.Cfg.Configuration().Configure();
    //    connectionString = cfg.GetProperty(NHibernate.Cfg.Environment.ConnectionString);

    //    if (connectionString == null)
    //        throw new Exception("Connection string not set up in Nhibernate configuration in web.config file");

    //    try
    //    {
    //        MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

    //        conn.Open();
    //        conn.Close();
    //        conn.Dispose();
    //    }

    //    catch
    //    {
    //        Server.Transfer("install/install.aspx");
    //    }


    //}

    protected void btnChangePass_Click(object sender, EventArgs e)
    {
        user.ChangePassword(txtOldPass.Text, Password.Text);
    }
    protected void btnChangeQnA_Click(object sender, EventArgs e)
    {
        user.ChangePasswordQuestionAndAnswer(txtOldPassQnA.Text, Question.Text, Answer.Text);
    }
    protected void btnUpdateProfile_Click(object sender, EventArgs e)
    {
        //ProfileCommon prof = Profile.GetProfile(p);
        //prof.setpropertyvalue("name", name.text);
        //prof.setpropertyvalue("surname", surname.text);
        //prof.setpropertyvalue("company", company.text);
        //prof.setpropertyvalue("phone", phone.text);
        //prof.setpropertyvalue("postalcode", postalcode.text);
        //prof.setpropertyvalue("timezone", ddntz.selectedvalue);


        Profile.Name = Name.Text;
        Profile.Surname = Surname.Text;
        Profile.Company = Company.Text;
        Profile.Phone = Phone.Text;
        Profile.TimeZone = ddnTimeZone.SelectedValue;
        Profile.PostalCode = PostalCode.Text;
    }

    private void fetchUserInfo(string p)
    {
        user = Membership.GetUser(HttpContext.Current.User.Identity.Name);

        UserName.Text = user.UserName; UserName.Enabled = false;
        Email.Text = user.Email; Email.Enabled = false;
        Question.Text = user.PasswordQuestion;

    }


    private void fetchProfile(string p)
    {

        ProfileCommon prof = Profile.GetProfile(p);

        //ddnTimeZone.DataSource = TimeZoneInfo.GetSystemTimeZones();
        //ddnTimeZone.DataValueField = "Id";
        //ddnTimeZone.DataTextField = "DisplayName";
        //ddnTimeZone.DataBind();

        Name.Text = prof.Name;
        Surname.Text = prof.Surname;
        Company.Text = prof.Company;
        Phone.Text = prof.Phone;
        PostalCode.Text = prof.PostalCode;
        //TimeZone.Text = prof.TimeZone;

        ddnTimeZone.DataBind();

        if (ddnTimeZone.Items.FindByValue(prof.TimeZone) != null)
        {
            ddnTimeZone.SelectedValue = prof.TimeZone;
        }


    }
}