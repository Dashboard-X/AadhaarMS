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

public partial class SiteMaster : System.Web.UI.MasterPage, IErrorMessage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Page.Title = "Aadhaar, " + Page.Title;
    }

    public void SetError(Type context, string message)
    {
        //Log.Error(context, message);
        lblErrorMasterPg.Text = message;

        lblErrorMasterPg.Visible = true;
    }

    public void SetError(Type context, Exception ex)
    {
        //Don't log ThreadAbortException because is fired each time a Redirect is called
        if (!(ex is System.Threading.ThreadAbortException))
        {
            //Log.Error(context, "Error", ex);

            if (ex is HttpUnhandledException && ex.InnerException != null)
                lblErrorMasterPg.Text = Aadhaar.Utilities.FormatException(ex.InnerException);
            else
                lblErrorMasterPg.Text = Aadhaar.Utilities.FormatException(ex);

            lblErrorMasterPg.Visible = true;
        }
    }
}