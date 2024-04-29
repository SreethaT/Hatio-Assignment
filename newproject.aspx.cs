using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace Todo
{
   
    
    public partial class newproject : System.Web.UI.Page
    {


        operation op = new operation();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                Session.Clear();
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            
                
            
            DateTime dt = Convert.ToDateTime(txtdate.Text);
            DateTime dt1 = Convert.ToDateTime(txtupdate.Text);
            op.iud("insert into Project values('" + txttitle.Text + "','" + dt.ToString("MM/dd/yyyy") + "','"+txtdo.Text+"')");
            op.iud("insert into Todo values('" + txtdes.Text + "','','" + dt.ToString("MM/dd/yyyy") + "','" + dt1.ToString("MM/dd/yyyy") + "')");
            Response.Write("<script> alert('Saved Successfully')</Script>");
            txtdo.Text = "";
            txtdes.Text = "";
            
            txtupdate.Text = "";
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

       
       
        
    }
}