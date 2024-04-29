using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for connection
/// </summary>
public class connection
{
    public SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=project1;Integrated Security=True;Pooling=False");
    public connection()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public void copen()
    {
        con.Open();
    }
    public void cclose()
    {
        con.Close();
    }
}