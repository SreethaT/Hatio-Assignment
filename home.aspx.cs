using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Todo
{
    public partial class home : System.Web.UI.Page
    {
        operation op = new operation();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
             DataSet ds = op.selectall("select * from Login where username='"+txtuser.Text+"' and password='"+txtpwd.Text+"'");
        if (ds.Tables[0].Rows.Count > 0)
        {
            Session["username"] = txtuser.Text;
            Session["user"]=txtuser.Text;
           Session["cid"] = txtuser.Text;
            string typ = ds.Tables[0].Rows[0][2].ToString();

            if (txtuser.Text == "user")
            {

                Response.Write("<script>alert('Login successful')</script>");
            }
            
        else
        {
            Response.Write("<script>alert('invalid login details')</script>");
        }
    }
        }
    }

         
}