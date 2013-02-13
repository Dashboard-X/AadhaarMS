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

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
            fetchProfile(HttpContext.Current.User.Identity.Name);
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
