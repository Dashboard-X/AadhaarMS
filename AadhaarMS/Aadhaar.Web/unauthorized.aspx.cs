using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class unauthorized : System.Web.UI.Page
{
   protected string offendingUrl;

    protected void Page_Load(object sender, EventArgs e)
    {
        offendingUrl = Request.QueryString[0];
    }
}