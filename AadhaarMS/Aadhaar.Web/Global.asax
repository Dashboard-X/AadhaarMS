<%@ Application Language="C#" %>
<%@ Import Namespace="System.Security.Principal" %>
<%@ Import Namespace="System.Reflection" %>
<%@ Import Namespace="NHibernate" %>

<script runat="server">

    public static string BaseURL
    {
        get { return HttpContext.Current.Request.Url.Scheme + "://" + HttpContext.Current.Request.Url.Authority + HttpContext.Current.Request.ApplicationPath.TrimEnd('/') + '/'; }
    }
    
    void Application_Start(object sender, EventArgs e) 
    {
                
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }

    protected void Application_AuthenticateRequest(Object sender, EventArgs e)
    {

        HttpCookie authCookie = Request.Cookies[
                     FormsAuthentication.FormsCookieName];
        if (authCookie != null)
        {
            //Extract the forms authentication cookie
            FormsAuthenticationTicket authTicket =
                   FormsAuthentication.Decrypt(authCookie.Value);

            string[] udata = authTicket.UserData.Split(new char[] { ';' });

            string usrEmail = "";
            int usrKey = 0;
            string roleStr = "";

            for (int count1 = 0; count1 <= udata.Length - 1; count1++)
            {
                if (udata[count1].Contains("Email="))
                    usrEmail = udata[count1].Replace("Email=", "");

                if (udata[count1].Contains("UKeyN="))
                    usrKey = Convert.ToInt32(udata[count1].Replace("UKeyN=", ""));

                if (udata[count1].Contains("roleStr="))
                    roleStr = udata[count1].Replace("roleStr=", "");
            }

            // Create an Identity object
            //CustomIdentity implements System.Web.Security.IIdentity
            
            GenericIdentity id = new GenericIdentity(authTicket.Name);
            //CustomPrincipal implements System.Web.Security.IPrincipal

            Context.User = new System.Security.Principal.GenericPrincipal(id, roleStr.Split(','));
        }
        
        
    }

    protected void Application_Error(Object sender, EventArgs e)
    {

        // Code that runs when an unhandled error occurs

        /*   Exception exc = Server.GetLastError();
           if (exc.Message.Contains("Unknown database "))
               Response.Redirect("Aadhaar.Web/install/install.aspx");*/
        
        // At this point we have information about the error
        HttpContext ctx = HttpContext.Current;

        Exception exception = ctx.Server.GetLastError();

        string errorInfo =
           "<br>Offending URL: " + ctx.Request.Url.ToString() +
           "<br>Source: " + exception.Source +
           "<br>Message: " + exception.Message +
           "<br>Stack trace: " + exception.StackTrace;
         Aadhaar.Utilities.TextLog(errorInfo);

         //Check if the exception type is Security Exception
         if (exception is System.Security.SecurityException)
         {
             Response.Redirect("~/unauthorized.aspx?p=" + Server.UrlEncode(Request.RawUrl));
         }
        
        //ctx.Response.Write(errorInfo);

         //ctx.Session["lasterror"] = errorInfo;

        // --------------------------------------------------
        // To let the page finish running we clear the error
        // --------------------------------------------------
        //ctx.Server.ClearError();
    }
       
</script>
