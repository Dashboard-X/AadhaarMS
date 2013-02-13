using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class install_install : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        NHibernate.Cfg.Configuration cfg = new NHibernate.Cfg.Configuration().Configure();
        String connectionString = cfg.GetProperty(NHibernate.Cfg.Environment.ConnectionString);
            string dbtype = cfg.GetProperty(NHibernate.Cfg.Environment.Dialect);

        lblConnStrName.Text = connectionString;
        lblNHDialect.Text=dbtype;
    }

        //private void InstallMysqlDb(string database, string uid, string pwd)
        //{



        //    string s="";

        //    s = "USE " +database + ";" +s;

        //    string[] sCommands =s.Split(';');

        //    int numBooBoos = 0;

        //    lblMessage.Text = "The Following Errors occurred:<BR>";

        //    foreach (string sCmd in sCommands)

        //    {

        //        try{
        //            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(lblConnStrName.Text);

        //            conn.Open();
        //            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sCmd,conn);

        //            cmd.ExecuteNonQuery();

        //        }

        //        catch(Exception ex)

        //        {

        //            numBooBoos++;

        //            lblMessage.Text+=ex.Message+"<BR>";

 

        //        }

        //    }

        //    if (numBooBoos == 0)

        //    {

        //        Response.Redirect("../default.aspx");

        //    } 

        //}

 
    protected void  btnCreateDb_Click(object sender, EventArgs e)
    {
        switch (drpDbType.SelectedItem.Value)
        {
            case ("Mysql"):
                //checkMysqlDb();
                break;
            case("-1"):
                lblMessage.Text = "Please select a database type";
                break;
            default:
                lblMessage.Text = "Unable to connect to Database. Please create a databae/choose another.";
                break;
        }
    }

    //private void checkMysqlDb()
    //{
    //    string connectionString = "Server="+txtDbSrvrName.Text + ";Database=" + txtDbName.Text+";User ID="+txtDbUserId.Text+";Password="+txtDbPass.Text+";";
    //    try
    //    {
    //        MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

    //        conn.Open();
    //        conn.Close();
    //        conn.Dispose();
    //    }

    //    catch(Exception exc)
    //    {
    //        lblMessage.Text = "Unable to Connect.<br/>Error:" + exc.Message;
    //    }
    //}

    private string fetchDbScript()
    {
        FileStream fs = new FileStream(Server.MapPath("mysql-install.sql"), FileMode.Open);

        byte[] b = new byte[(int)fs.Length];

        fs.Read(b, 0, b.Length);

        fs.Close();

        string s = System.Text.Encoding.ASCII.GetString(b);

        return (s);
    }
    protected void btnExecuteScript_Click(object sender, EventArgs e)
    {

    }
}