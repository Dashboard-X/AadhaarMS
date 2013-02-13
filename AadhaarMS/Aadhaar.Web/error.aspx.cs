using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class error : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Exception exception = HttpContext.Current.Server.GetLastError();

        lblErrorDetails.Text = "Error:<br/>"+
           "<br>Source: " + exception.Source +
           "<br>Message: " + exception.Message +
           "<br>Stack trace: " + exception.StackTrace;

        
    }
}