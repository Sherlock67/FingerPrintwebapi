using NLog.Internal;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public partial class Demo1 : System.Web.UI.Page
{
    SqlConnection myConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
            
    }

}